using ServicesApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace ServicesApp.Core.Commands
{
    public class CreateCategoryCommand : BaseCommand
    {
        public int Id { get; set; }
    }
}
