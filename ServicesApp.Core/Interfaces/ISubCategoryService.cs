using Ardalis.Result;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.Interfaces
{
    internal interface ISubCategoryService
    {

        Task CreateSubCategory(SubCategory category);

        Result<IAsyncEnumerable<SubCategory>> GetSubCategoties();

        Task<Result<SubCategory>> GetSubCategory(int id);
    }
}
