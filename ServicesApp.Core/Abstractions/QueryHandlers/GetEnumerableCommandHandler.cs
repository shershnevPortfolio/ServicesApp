using Ardalis.Result;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Abstractions.Queries;
using ServicesApp.Core.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.Abstractions.QueryHandlers
{
    internal abstract class GetEnumerableQueryHandler<TQuery, TResult, TEntity> : BaseQueryHandler<TQuery, TResult, TEntity>
        where TResult : IEnumerable
        where TQuery : GetEnumerableQuery<TResult>
        where TEntity : BaseEntity
    {
        private readonly IRepository<TEntity> _repository; 
        protected GetEnumerableQueryHandler(IQueryHandlerService<TEntity> handlerService) : base(handlerService)
        {
            _repository = _handlerService.Repository;
        }

        public async override Task<Result<TResult>> Handle(TQuery query)
        {
            throw new NotImplementedException();
        }
    }
}
