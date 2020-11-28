using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.Abstractions.Commands
{
    public abstract class CrudCommand : BaseCommand
    {
        public int Id { get; set; }
    }
}
