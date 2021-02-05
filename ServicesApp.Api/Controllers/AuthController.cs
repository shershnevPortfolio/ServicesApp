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
using Ardalis.Result.AspNetCore;
using MediatR;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServicesApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [TranslateResultToActionResult]

    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("register")]
        [HttpPost]
        public async Task<Result<object>> Register(RegisterCommand command)
        {
            return await _mediator.Send(command);
        }


        [Route("login")]
        [HttpPost]
        public async Task<Result<object>> Login(LoginCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
