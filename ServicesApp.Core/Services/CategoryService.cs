using ServicesApp.Core.Entities;
using ServicesApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IAsyncEnumerable<Category> GetCategoties()
        {
            return _unitOfWork.CategoryRepository.GetAll();
        }

        public async Task<Category> GetCategory(int id)
        {
            return await _unitOfWork.CategoryRepository.GetById(id);
        }

        public async Task CreateCategory(Category category)
        {
            await _unitOfWork.CategoryRepository.Add(category);
            await _unitOfWork.SaveChangesAsync();
        }
        
        public async Task<IEnumerable<SubCategory>> GetSubcategoriesByCategory(int id)
        {
            return await _unitOfWork.CategoryRepository.GetSubcategories(id);
        }
    }
}
