using ServicesApp.Core.Commands;
using ServicesApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.CommandsHandlers
{
    class RegisterCommandHandler : ICommandHandler<LoginCommand>
    {
        public void Handle(LoginCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
