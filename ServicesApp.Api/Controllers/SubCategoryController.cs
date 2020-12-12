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
        public async Task<Result<object>> Post(CreateSubcategoryCommand command)
        {
            await _commandHandler.Handle<CreateSubcategoryCommand>(command);
            return command.Result;
        }

        [HttpGet]
        public async Task<Result<object>> Get(GetSubcategoriesCommand command)
        {
            return await _commandHandler.Handle<GetSubcategoriesCommand, IEnumerable<SubcategoryDTO>>(command);
        }

    }
}
