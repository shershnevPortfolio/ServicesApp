using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.Abstractions.Commands
{
    public class GetEnumerableCommand<TEntity> : CrudCommand where TEntity : BaseEntity
    {
        public override async Task Accept(ICommandVisiter visiter)
        {
            await visiter.Visit<TEntity>(this);
        }

    }
}
