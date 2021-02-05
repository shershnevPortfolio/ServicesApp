using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ServicesApp.Core.Abstractions.Queries;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Entities;
using ServicesApp.Core.Abstractions.Commands;
using Ardalis.Result;
using MediatR;
using System.Threading;

namespace ServicesApp.Core.Abstractions.CommandHandlers
{
    abstract class CreateCommandHandler<TCommand, TEntity> : BaseCrudCommandHandler<TCommand> 
            where TCommand : CreateCommand<TEntity>
            where TEntity : BaseEntity
    {
        protected readonly ICommandHandlerService<TEntity> _commandHandlerService;

        private readonly IRepository<TEntity> _repository;

        public CreateCommandHandler(IUnitOfWork unitOfWork, ICommandHandlerService<TEntity> commandHandlerService) : base(unitOfWork)
        {
            _commandHandlerService = commandHandlerService;
            _repository = _commandHandlerService.Repository;
        }


        public async override Task<Result<Unit>> Handle(TCommand request, CancellationToken cancellationToken) 
        {

            await _repository.Add(_commandHandlerService.MapToDomain(request));
            return new Unit();
        }

    }
}
