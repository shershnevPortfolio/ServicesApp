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

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace ServicesApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [TranslateResultToActionResult]

    public class CategoryController : ControllerBase
    {
        private readonly ICommandHandler _commandHandler;

        public CategoryController(ICommandHandler commandHandler)
        {
            _commandHandler = commandHandler;
        }

        [HttpGet]
        public async Task<Result<object>> Get(GetSubcategoriesQuery query)
        {
           return  await _commandHandler.Handle<GetSubcategoriesQuery, IEnumerable<CategoryDTO>>(query);
        }


        [HttpGet("{id}")]
        public async Task<Result<object>> Get([FromRoute] GetCategoryQuery query)
        {
            return await _commandHandler.Handle<GetCategoryQuery, CategoryDTO>(query);
        }

        [HttpGet("{id}/subcategories")]
        public async Task<Result<IEnumerable<Subcategory>>> GetSubcategories(int id)
        {
            throw new NotImplementedException();
        }



        [HttpPost]
        public async Task Post(CreateCategoryCommand command)
        {
            await _commandHandler.Handle<CreateCategoryCommand>(command);
        }
    }
}
