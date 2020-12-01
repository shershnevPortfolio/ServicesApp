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

        Task CreateSubCategory(Subcategory category);

        Result<IAsyncEnumerable<Subcategory>> GetSubCategoties();

        Task<Result<Subcategory>> GetSubCategory(int id);
    }
}
