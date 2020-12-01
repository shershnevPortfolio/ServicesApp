using ServicesApp.Core.Abstractions.Commands;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.Commands
{
    public class GetCommand<TEntity> : CrudCommand where TEntity : BaseEntity
    {
        public int Id { get; set; } 
        public override async Task Accept(ICommandVisiter visiter)
        {
            await visiter.Visit<TEntity>(this);
        }
    }
}
