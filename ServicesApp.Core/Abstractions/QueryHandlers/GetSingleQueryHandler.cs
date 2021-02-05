using Ardalis.Result;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Abstractions.Queries;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServicesApp.Core.Abstractions.QueryHandlers
{
    internal class GetSingleQueryHandler<TQuery, TResult, TEntity> : BaseQueryHandler<TQuery, TResult, TEntity>
        where TQuery : GetSingleQuery<TResult>
        where TEntity : BaseEntity
    {
        private readonly IRepository<TEntity> _repository;

        public GetSingleQueryHandler(IQueryHandlerService<TEntity> handlerService) : base(handlerService)
        {
            _repository = _handlerService.Repository;
        }


        public async override Task<Result<TResult>> Handle(TQuery request, CancellationToken cancellationToken)
        {
            return _handlerService.CreateResult<TResult>(await _repository.GetById(request.Id));
        }
    }
}
