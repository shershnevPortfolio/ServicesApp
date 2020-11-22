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
    public class SubCategoryController : ControllerBase
    {
        private readonly ISubCategoryService _subCategoryService;
        public SubCategoryController(ISubCategoryService subCategoryService)
        {
            _subCategoryService = subCategoryService;
        }

        [HttpPost]
        public async Task Post(SubCategory subCategory)
        {

            await _subCategoryService.CreateSubCategory(subCategory);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var subCategory = _subCategoryService.GetSubCategoties();
            if (subCategory == null)
            {
                return NotFound(new { message = "not found" });
            }

            return Ok(subCategory);
        }

    }
}
