using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.Result;
using Ardalis.Result.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Commands;

namespace ServicesApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [TranslateResultToActionResult]

    public class OrderController : ControllerBase
    {
        private readonly ICommandHandler _commandHandler;

        public OrderController(ICommandHandler commandHandler)
        {
            _commandHandler = commandHandler;
        }

        [HttpGet]
        public async Task<Result<object>> Get(GetOrdersCommand command)
        {
            await _commandHandler.Handle<GetOrdersCommand>(command);
            return command.Result;

        }


        [HttpGet("{id}")]
        public async Task<Result<object>> Get([FromRoute] GetOrderCommand command)
        {
            await _commandHandler.Handle<GetOrderCommand>(command);
            return command.Result;
        }

        [HttpPost]
        public async Task<Result<object>> Create(CreateOrderCommand command)
        {
            await _commandHandler.Handle<CreateOrderCommand>(command);
            return command.Result;
        }

    }
}
