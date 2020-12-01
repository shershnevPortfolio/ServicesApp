using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Entities;
using ServicesApp.Core.Interfaces;

namespace ServicesApp.Core.Services
{
    internal class SubCategoryService : ISubCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IResultCreationService _resultCreationService;

        public SubCategoryService(IUnitOfWork unitOfWork, IResultCreationService resultCreationService)
        {
            _unitOfWork = unitOfWork;
            _resultCreationService = resultCreationService;
    }

        public async Task CreateSubCategory(Subcategory category)
        {
            await _unitOfWork.SubCategoryRepository.Add(category);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<Result<Subcategory>> GetSubCategory(int id)
        {
            var subcategory = await _unitOfWork.SubCategoryRepository.GetById(id);
            return _resultCreationService.CreateResult<Subcategory>(subcategory);
        }

        public  Result<IAsyncEnumerable<Subcategory>> GetSubCategoties()
        {
            var subCategories = _unitOfWork.SubCategoryRepository.GetAll();
            return _resultCreationService.CreateResult<IAsyncEnumerable<Subcategory>>(subCategories);
        }
    }
}
