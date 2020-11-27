using AutoMapper;
using Microsoft.AspNetCore.Identity;
using ServicesApp.Core.DTOs;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using ServicesApp.Core.Interfaces;
using Ardalis.Result;
using System.Threading.Tasks;
using ServicesApp.Core.Commands;

namespace ServicesApp.Core.Services
{
    internal class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<User> _userManager;

        private readonly IMapper _mapper;

        private readonly IResultCreationService _resultCreationService;

        private readonly IValidationService _validationService;

        public AuthenticationService(UserManager<User> userManager, IResultCreationService resultCreationService, IValidationService validationService)
        {
            _userManager = userManager;
            _resultCreationService = resultCreationService;
            _validationService = validationService;
        }

        public async Task<Result<IdentityResult>> RegisterUser(RegisterCommand registerData)
        {
            var user = _mapper.Map<User>(registerData);
            var result = await _userManager.CreateAsync(user, registerData.Password);
            return _resultCreationService.CreateResult<IdentityResult>(result);
        }

        public async Task<Result<UserDTO>> Login(LoginCommand loginData)
        {
            var user = await _userManager.FindByNameAsync(loginData.UserName);
            _validationService.ValidateQueryResult<User>(user);
            var token = await _userManager.CreateSecurityTokenAsync(user);
            return _resultCreationService.CreateResult<UserDTO>(_mapper.Map<UserDTO>(user));
        }
    }
}
