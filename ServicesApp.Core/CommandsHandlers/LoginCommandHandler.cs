using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Commands;

namespace ServicesApp.Core.CommandsHandlers
{
    internal class LoginCommandHandler : ICommandHandler<LoginCommand>
    {
        private readonly IAuthenticationService _authenticationService;

        public LoginCommandHandler(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public async Task Handle(LoginCommand command)
        {
            throw new NotImplementedException();
        }

       
    }
} 
