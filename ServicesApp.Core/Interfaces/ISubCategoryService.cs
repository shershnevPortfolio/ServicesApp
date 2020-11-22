using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.Interfaces
{
    public interface ISubCategoryService
    {
        Task<SubCategory> GetSubCategory(int id);

        Task CreateSubCategory(SubCategory category);

        IAsyncEnumerable<SubCategory> GetSubCategoties();
    }
}
