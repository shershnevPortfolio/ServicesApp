using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ServicesApp.Core.Entities;
using ServicesApp.Core.Interfaces;

namespace ServicesApp.Core.Services
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        public SubCategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateSubCategory(SubCategory category)
        {
            await _unitOfWork.SubCategoryRepository.Add(category);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<SubCategory> GetSubCategory(int id)
        {
            return  await _unitOfWork.SubCategoryRepository.GetById(id);
        }

        public  IAsyncEnumerable<SubCategory> GetSubCategoties()
        {
            return  _unitOfWork.SubCategoryRepository.GetAll();
        }
    }
}
