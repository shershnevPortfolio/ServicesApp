using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ServicesApp.Core.Entities;
using AutoMapper;
using ServicesApp.Core.DTOs;
using ServicesApp.Core.Interfaces;
using Ardalis.Result;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServicesApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthenticationService _authenticationService;

        public AuthController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [Route("register")]
        [HttpPost]
        public async Task<Result<IdentityResult>> Register(RegisterDTO registerData)
        {
            return await _authenticationService.RegisterUser(registerData);
        }


        [Route("login")]
        [HttpPost]
        public async Task<Result<UserDTO>> Login(LoginDTO loginData)
        {
            return await _authenticationService.Login(loginData);
        }

    }
}
