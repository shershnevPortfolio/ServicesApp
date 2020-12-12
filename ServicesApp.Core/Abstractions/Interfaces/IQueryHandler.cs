using Ardalis.Result;
using ServicesApp.Core.Abstractions.Queries;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.Abstractions.Interfaces
{
    internal interface IQueryHandler<TQuery, TResult>
        where TQuery : BaseQuery<TResult>
    {
        Task<Result<TResult>> Handle(TQuery query);
    }
}
