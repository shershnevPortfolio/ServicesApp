using Ardalis.Result;
using MediatR;
using ServicesApp.Core.Abstractions.Commands;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Abstractions.Specifications.UpdateSpecifications;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServicesApp.Core.Abstractions.CommandHandlers
{
    internal abstract class UpdateCommandHandler<TCommand, TEntity> : BaseCrudCommandHandler<TCommand>
        where TCommand : UpdateCommand<TEntity>
        where TEntity : BaseEntity
    {
        protected readonly ICommandHandlerService<TEntity> _handlerService;
        protected readonly IRepository<TEntity> _repository;
        protected UpdateCommandHandler(IUnitOfWork unitOfWork, ICommandHandlerService<TEntity> handlerService) : base(unitOfWork)
        {
            _handlerService = handlerService;
            _repository = _handlerService.Repository;
        }

        public async override Task<Result<Unit>> Handle(TCommand request, CancellationToken cancellationToken)
        {
            await _repository.Update(request.Id, GetSpecification(request));
            return new Unit();
        }

        protected abstract UpdateSpecification<TEntity> GetSpecification(TCommand request);

    }
}
