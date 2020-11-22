using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.Interfaces
{
    public interface ICategoryService
    {
        Task<Category> GetCategory(int id);

        IAsyncEnumerable<Category> GetCategoties();

        Task CreateCategory(Category category);

        Task<IEnumerable<SubCategory>> GetSubcategoriesByCategory(int id);
    }
}
