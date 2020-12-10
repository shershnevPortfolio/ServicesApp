using Ardalis.Result;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Abstractions.Queries;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.Abstractions.QueryHandlers
{
    class BaseQueryHandler<TQuery, TResult> : IQueryHandler<TQuery, TResult>
    {
       
        public TResult Handle(BaseQuery<BaseEntity, TResult> query)
        {
            throw new NotImplementedException();
        }
    }
}
