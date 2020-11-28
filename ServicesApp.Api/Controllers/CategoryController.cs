using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServicesApp.Core.Entities;
using Ardalis.Result.AspNetCore;
using Ardalis.Result;
using ServicesApp.Core.Commands;
using ServicesApp.Core.Abstractions.Interfaces;

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
        public async Task Get(GetCategoryCommand command)
        {
            await _commandHandler.Handle<GetCategoryCommand>(command);

        }


        [HttpGet("{id}")]
        public async Task Get(int id)
        {
            var command = new GetCategoryCommand() { Id = id};
            await _commandHandler.Handle<GetCategoryCommand>(command);
        }

        [HttpGet("{id}/subcategories")]
        public async Task<Result<IEnumerable<SubCategory>>> GetSubcategories(int id)
        {
            throw new NotImplementedException();
        }



        [HttpPost]
        public async Task<IActionResult> Post(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
