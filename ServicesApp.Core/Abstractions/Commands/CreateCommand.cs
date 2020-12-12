using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.Abstractions.Commands
{
    public abstract class CreateCommand<TEntity> : CrudCommand where TEntity : BaseEntity
    {
    
    }
}
