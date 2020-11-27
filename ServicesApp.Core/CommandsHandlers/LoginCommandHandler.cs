using System;
using System.Collections.Generic;
using System.Text;
using ServicesApp.Core.Commands;
using ServicesApp.Core.Interfaces;

namespace ServicesApp.Core.CommandsHandlers
{
    public class LoginCommandHandler : ICommandHandler<LoginCommand>
    {
        private readonly IAuthenticationService _authenticationService;

        public LoginCommandHandler(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public void Handle(LoginCommand command)
        {
            throw new NotImplementedException();
        }

       
    }
} 
