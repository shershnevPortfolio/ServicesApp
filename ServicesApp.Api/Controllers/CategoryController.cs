using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServicesApp.Core.Entities;
using ServicesApp.Core.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServicesApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var categories = _categoryService.GetCategoties();
            if (categories == null)
            {
                return NotFound(new { message = "not found" });
            }

            return Ok(categories);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var category = await _categoryService.GetCategory(id);
            if(category == null)
            {
                return NotFound(new { message = "not found" });
            }

            return Ok(category);
        }

        [HttpGet("{id}/subcategories")]
        public async Task<IActionResult> GetSubcategories(int id)
        {
            var subCategories = await _categoryService.GetSubcategoriesByCategory(id);
            if (subCategories == null)
            {
                return NotFound(new { message = "not found" });
            }

            return Ok(subCategories);
        }



        [HttpPost]
        public async Task<IActionResult> Post(Category category)
        {
            await _categoryService.CreateCategory(category);
            return Ok(new { data =  category });
        }
    }
}
