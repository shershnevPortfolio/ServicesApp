using System;
using System.Collections.Generic;
using System.Text;
using ServicesApp.Core.Interfaces;
using ServicesApp.Core.Commands;
using Ardalis.Result;

namespace ServicesApp.Core.Decorators.CommandHandlerDecorators
{
    internal class ValidationCommandHandlerDecorator<TCommand> : ICommandHandler<TCommand>
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

        public void Handle(TCommand command)
        {
            _validationService.ValidateQuery<TCommand>(command);
            _decorated.Handle(command);
            _validationService.ValidateQueryResult<TCommand>(command);
           
        }
    }
}
