using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.DTOs;
using ServicesApp.Core.Entities;
using ServicesApp.Core.Options;
using ServicesApp.Core.Commands;

namespace ServicesApp.Core.CommandHandlers
{
    internal class LoginCommandHandler : ICommandHandler<LoginCommand>
    {

        private readonly UserManager<User> _userManager;

        private readonly IResultCreationService _resultCreationService;

        private readonly IValidationService _validationService;

        private readonly IMapper _mapper;

        public LoginCommandHandler(UserManager<User> userManager, IResultCreationService resultCreationService, IValidationService validationService, IMapper mapper)
        {
            _userManager = userManager;
            _resultCreationService = resultCreationService;
            _validationService = validationService;
            _mapper = mapper;
        }


        public async Task Handle(LoginCommand command)
        {
            var user = await _userManager.FindByNameAsync(command.UserName);

            if (user != null && await _userManager.CheckPasswordAsync(user, command.Password) )
            {
                var userId = user.Id;
                var token = await _userManager.CreateSecurityTokenAsync(user);
                command.Result = Result<object>.Success(new { user = _mapper.Map<UserDTO>(user), token });
               
            }
        }

       
    }
} 
