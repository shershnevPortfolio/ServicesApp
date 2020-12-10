using ServicesApp.Core.Abstractions.Queries;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.Abstractions.Interfaces
{
    internal interface IQueryHandler<TQuery, TResult>
    {
        TResult Handle(BaseQuery<TResult> query);
    }
}
