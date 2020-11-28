using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Commands;
using ServicesApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.CommandsHandlers
{
    internal class RegisterCommandHandler : ICommandHandler<RegisterCommand>
    {
        public async Task Handle(RegisterCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
