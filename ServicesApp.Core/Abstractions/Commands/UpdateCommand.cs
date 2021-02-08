using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.Abstractions.Commands
{
    public class UpdateCommand<TEntity> : CrudCommand where TEntity : BaseEntity
    {
        public int Id { get; set; }
    }
}
