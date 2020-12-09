using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.Abstractions.Commands
{
    public class GetCommand<TEntity> : CrudCommand where TEntity : BaseEntity
    {
        public int Id { get; set; } 
        public override async Task Accept(ICommandVisitor visiter)
        {
            await visiter.Visit<TEntity>(this);
        }
    }
}
