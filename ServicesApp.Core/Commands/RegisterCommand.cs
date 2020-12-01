using ServicesApp.Core.Abstractions.Commands;
using System;
using System.Collections.Generic;
using System.Text;


namespace ServicesApp.Core.Commands
{
    public class RegisterCommand : BaseCommand
    {
        public string Password { get; set; }

        public string UserName { get; set; }

    }
}
