using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.Result;
using Ardalis.Result.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using ServicesApp.Core.Entities;
using ServicesApp.Core.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServicesApp.Api.Controllers
{
    [TranslateResultToActionResult]
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryController : ControllerBase
    {
        private readonly ICommandHandler _commandHandler;
        public SubCategoryController(ICommandHandler commandHandler)
        {
            _commandHandler = commandHandler;
        }

        [HttpPost]
        public async Task Post(SubCategory subCategory)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Result<IAsyncEnumerable<SubCategory>> Get()
        {
            throw new NotImplementedException();

        }

    }
}
