using ServicesApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace ServicesApp.Core.Commands
{
    class RegisterCommand : ICommand
    {
        public string Password { get; set; }

        public string UserName { get; set; }

        public string Result { get; set; }
    }
}
