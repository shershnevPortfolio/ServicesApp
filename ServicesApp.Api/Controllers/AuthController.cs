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
using ServicesApp.Core.Commands;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServicesApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ICommandHandler<LoginCommand> _loginCommandHandler;
        private readonly ICommandHandler<RegisterCommand> _registerCommandHandler;

        public AuthController(ICommandHandler<LoginCommand> loginCommandHandler, ICommandHandler<RegisterCommand> registerCommandHandler)
        {
            _loginCommandHandler = loginCommandHandler;
            _registerCommandHandler = registerCommandHandler;
        }

        [Route("register")]
        [HttpPost]
        public async Task Register(RegisterCommand registerData)
        {
            _registerCommandHandler.Handle(registerData);
        }


        [Route("login")]
        [HttpPost]
        public async Task Login(LoginCommand loginData)
        {
            _loginCommandHandler.Handle(loginData);

        }
    }
}
