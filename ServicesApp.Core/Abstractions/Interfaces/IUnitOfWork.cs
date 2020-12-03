using ServicesApp.Core.Abstractions.Commands;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.Abstractions.Interfaces
{
    public interface IUnitOfWork
    {
        void SaveChanges();

        Task SaveChangesAsync();

        IRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity;
    }
}
