using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.Interfaces
{
    public interface IUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; }

        IRepository<SubCategory> SubCategoryRepository { get; }

        void SaveChanges();

        Task SaveChangesAsync();
    }
}
