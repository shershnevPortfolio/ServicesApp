using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ServicesApp.Core.Abstractions.Queries;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Entities;

namespace ServicesApp.Core.Abstractions.CommandHandlers
{
    abstract class CreateCommandHandler<TCommand, TEntity> : BaseCrudCommandHandler<TCommand> 
            where TCommand : CreateCommand<TEntity>
            where TEntity : BaseEntity
    {
        protected readonly ICommandHandlerService<TEntity> _commandHandlerService;

        private readonly IRepository<TEntity> _repository;

        public CreateCommandHandler(IUnitOfWork unitOfWork, ICommandVisitor visiter, ICommandHandlerService<TEntity> commandHandlerService) : base(unitOfWork, visiter)
        {
            _commandHandlerService = commandHandlerService;
            _repository = _commandHandlerService.Repository;
        }

        public async  override Task Handle(TCommand command)
        {
             await _repository.Add(_commandHandlerService.MapToDomain(command));
        }

    }
}
