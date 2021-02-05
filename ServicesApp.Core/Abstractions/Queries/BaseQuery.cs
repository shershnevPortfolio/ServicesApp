using Ardalis.Result;
using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace ServicesApp.Core.Abstractions.Queries
{
    public abstract class BaseQuery<TResult> : IRequest<Result<TResult>>
    {
        
    }
}
