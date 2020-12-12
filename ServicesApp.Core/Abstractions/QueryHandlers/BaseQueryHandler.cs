using Ardalis.Result;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Abstractions.Queries;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.Abstractions.QueryHandlers
{
    internal abstract class BaseQueryHandler<TQuery, TResult, TEntity> : IQueryHandler<TQuery, TResult>
        where TQuery : BaseQuery<TResult>
        where TEntity : BaseEntity
    {
        protected readonly IQueryHandlerService<TEntity> _handlerService;

        protected BaseQueryHandler(IQueryHandlerService<TEntity> handlerService)
        {
            _handlerService = handlerService;

        }

        public abstract Task<Result<TResult>> Handle(TQuery query);

    }
}
