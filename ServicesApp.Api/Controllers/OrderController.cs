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
using ServicesApp.Core.DTOs;
using ServicesApp.Core.Queries;
using MediatR;


namespace ServicesApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [TranslateResultToActionResult]

    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<Result<object>> Get(GetOrdersQuery query)
        {
            return await _mediator.Send(query);
        }


        [HttpGet("{id}")]
        public async Task<Result<OrderDTO>> Get([FromRoute] GetOrderQuery query)
        {
           return await _mediator.Send(query);
        }

        [HttpPost]
        public async Task<Result<object>> Create(CreateOrderCommand command)
        {
            return await _mediator.Send(command);
        }

    }
}
