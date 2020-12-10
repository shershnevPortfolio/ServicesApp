using System;
using System.Collections.Generic;
using System.Text;
using ServicesApp.Core.Commands;
using Ardalis.Result;
using System.Threading.Tasks;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Abstractions.Queries;

namespace ServicesApp.Core.Decorators.CommandHandlerDecorators
{
    internal class ValidationCommandHandlerDecorator<TCommand> : ICommandHandler<TCommand> where TCommand : BaseCommand
    {
        private readonly ICommandHandler<TCommand> _decorated;

        private readonly IValidationService _validationService;

        private readonly IResultCreationService _resultCreationService;

        public ValidationCommandHandlerDecorator(ICommandHandler<TCommand> decorated, IValidationService validationService, IResultCreationService resultCreationService)
        {
            _decorated = decorated;
            _validationService = validationService;
            _resultCreationService = resultCreationService;
        }

        public async Task Handle(TCommand command)
        {
            _validationService.ValidateQuery<TCommand>(command);
            await _decorated.Handle(command);
            _validationService.ValidateQueryResult<TCommand>(command);
           
        }
    }
}
