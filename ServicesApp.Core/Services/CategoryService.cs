using ServicesApp.Core.Entities;
using ServicesApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Ardalis.Result;
using System.Threading.Tasks;

namespace ServicesApp.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IResultCreationService _resultCreationService;

        public CategoryService(IUnitOfWork unitOfWork, IResultCreationService resultCreationService)
        {
            _unitOfWork = unitOfWork;
            _resultCreationService = resultCreationService;
        }

        public Result<IAsyncEnumerable<Category>> GetCategoties()
        {
            var categories = _unitOfWork.CategoryRepository.GetAll();
            return _resultCreationService.CreateResult<IAsyncEnumerable<Category>>(categories);
        }

        public async Task<Result<Category>> GetCategory(int id)
        {
            var category = await _unitOfWork.CategoryRepository.GetById(id);
            return _resultCreationService.CreateResult<Category>(category);
        }

        public async Task CreateCategory(Category category)
        {
            await _unitOfWork.CategoryRepository.Add(category);
            await _unitOfWork.SaveChangesAsync();
        }
        
        public async Task<Result<IEnumerable<SubCategory>>> GetSubcategoriesByCategory(int id)
        {
            var subCategories = await _unitOfWork.CategoryRepository.GetSubcategories(id);
            return _resultCreationService.CreateResult<IEnumerable<SubCategory>>(subCategories);
        }
    }
}
