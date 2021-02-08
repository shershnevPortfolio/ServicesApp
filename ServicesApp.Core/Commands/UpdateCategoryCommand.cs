using ServicesApp.Core.Abstractions.Commands;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.Commands
{
    public class UpdateCategoryCommand : UpdateCommand<Category>
    {
        public string Name { get; set; }
    }
}
