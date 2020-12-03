using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Commands;
using ServicesApp.Core.Entities;
using ServicesApp.Core.Options;

namespace ServicesApp.Core.CommandsHandlers
{
    internal class LoginCommandHandler : ICommandHandler<LoginCommand>
    {

        private readonly UserManager<User> _userManager;

        private readonly IResultCreationService _resultCreationService;

        private readonly IValidationService _validationService;

        public LoginCommandHandler(UserManager<User> userManager, IResultCreationService resultCreationService, IValidationService validationService)
        {
            _userManager = userManager;
            _resultCreationService = resultCreationService;
            _validationService = validationService;
        }


        public async Task Handle(LoginCommand command)
        {
            var user = await _userManager.FindByNameAsync(command.UserName);

            if (user != null && await _userManager.CheckPasswordAsync(user, command.Password) )
            {
                var userId = user.Id;
                var token = await _userManager.CreateSecurityTokenAsync(user);
                command.Result = Result<object>.Success(new { user, token });
               
            }
        }

       
    }
} 
