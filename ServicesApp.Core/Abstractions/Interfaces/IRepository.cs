using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ServicesApp.Core.Entities;

namespace ServicesApp.Core.Abstractions.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        IAsyncEnumerable<T> GetAll();

        Task<T> GetById(int id);

        Task Add(T entity);

        void Update(T entity);

        Task Delete(int id);
    }
}
