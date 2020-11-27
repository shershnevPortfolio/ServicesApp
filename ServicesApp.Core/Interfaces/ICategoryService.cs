using Ardalis.Result;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.Interfaces
{
    internal interface ICategoryService
    {
        Task<Result<Category>> GetCategory(int id);

        Result<IAsyncEnumerable<Category>> GetCategoties();

        Task CreateCategory(Category category);

        Task<Result<IEnumerable<SubCategory>>> GetSubcategoriesByCategory(int id);
    }
}
