using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServicesApp.Core.Entities;
using ServicesApp.Core.Interfaces;
using Ardalis.Result.AspNetCore;
using Ardalis.Result;

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
        public Result<IAsyncEnumerable<Category>> Get()
        {
            throw new NotImplementedException();
                 
        }


        [HttpGet("{id}")]
        public async Task<Result<Category>> Get(int id)
        {
            throw new NotImplementedException();
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
