using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServicesApp.Core.Entities;
using Ardalis.Result.AspNetCore;
using Ardalis.Result;
using ServicesApp.Core.Queries;
using ServicesApp.Core.Commands;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.DTOs;
using MediatR;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace ServicesApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [TranslateResultToActionResult]

    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<Result<object>> Get(GetCategoriesQuery query)
        {
            return await _mediator.Send(query);
        }


        [HttpGet("{id}")]
        public async Task<Result<CategoryDTO>> Get([FromRoute] GetCategoryQuery query)
        {
            var result = await _mediator.Send(query);
            return result;
        }

        [HttpGet("{id}/subcategories")]
        public async Task<Result<IEnumerable<Subcategory>>> GetSubcategories(int id)
        {
            throw new NotImplementedException();
        }



        [HttpPost]
        public async Task<Result<object>> Post(CreateCategoryCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
