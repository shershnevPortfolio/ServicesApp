using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.Result;
using Ardalis.Result.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Queries;
using ServicesApp.Core.Entities;
using ServicesApp.Core.DTOs;
using ServicesApp.Core.Commands;
using MediatR;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServicesApp.Api.Controllers
{
    [TranslateResultToActionResult]
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SubCategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<Result<object>> Post(CreateSubcategoryCommand command)
        {
           return await _mediator.Send(command);
        }

        [HttpGet("{id}")]
        public async Task<Result<SubcategoryDTO>> Get(GetSubcategoryQuery query) 
        {
            return await _mediator.Send(query);
        }

        [HttpGet]
        public async Task<Result<object>> Get(GetSubcategoriesQuery query)
        {
            return await _mediator.Send(query);
        }

    }
}
