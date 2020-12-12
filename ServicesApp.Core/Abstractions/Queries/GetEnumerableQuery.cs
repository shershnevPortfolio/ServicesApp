using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.Abstractions.Queries
{
    public abstract class GetEnumerableQuery<TResult> : BaseQuery<TResult> 
        where TResult : IEnumerable
    {
    }
}
