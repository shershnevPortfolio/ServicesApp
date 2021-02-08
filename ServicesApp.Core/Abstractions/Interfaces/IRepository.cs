using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ServicesApp.Core.Entities;
using ServicesApp.Core.Abstractions.Specifications.UpdateSpecifications;

namespace ServicesApp.Core.Abstractions.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        IAsyncEnumerable<T> GetAll();

        Task<T> GetById(int id);

        Task Add(T entity);

        void Update(T entity);

        Task Delete(int id);

        Task Update(int id, UpdateSpecification<T> specification);
    }
}
