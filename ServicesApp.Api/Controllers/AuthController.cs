using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ServicesApp.Core.Entities;
using AutoMapper;
using ServicesApp.Core.DTOs;
using Ardalis.Result;
using ServicesApp.Core.Commands;
using ServicesApp.Core.Abstractions.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServicesApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ICommandHandler _commandHandler;

        public AuthController(ICommandHandler commandHandler)
        {
            _commandHandler = commandHandler;
        }

        [Route("register")]
        [HttpPost]
        public async Task Register(RegisterCommand registerData)
        {
            _commandHandler.Handle<RegisterCommand>(registerData);
        }


        [Route("login")]
        [HttpPost]
        public async Task Login(LoginCommand loginData)
        {
            _commandHandler.Handle<LoginCommand>(loginData);

        }
    }
}
