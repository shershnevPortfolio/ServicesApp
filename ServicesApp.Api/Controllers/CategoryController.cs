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
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public Result<IAsyncEnumerable<Category>> Get()
        {
            return _categoryService.GetCategoties();      
        }


        [HttpGet("{id}")]
        public async Task<Result<Category>> Get(int id)
        {
             return await _categoryService.GetCategory(id);
        }

        [HttpGet("{id}/subcategories")]
        public async Task<Result<IEnumerable<SubCategory>>> GetSubcategories(int id)
        {
            return await _categoryService.GetSubcategoriesByCategory(id);
           
        }



        [HttpPost]
        public async Task<IActionResult> Post(Category category)
        {
            await _categoryService.CreateCategory(category);
            return Ok(new { data =  category });
        }
    }
}
