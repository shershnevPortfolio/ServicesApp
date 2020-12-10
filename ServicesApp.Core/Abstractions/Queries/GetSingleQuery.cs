using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.Abstractions.Queries
{
    public class GetSingleQuery<TResult> : BaseQuery<TResult>
    {
        public int Id { get; set; } 
    }
}
