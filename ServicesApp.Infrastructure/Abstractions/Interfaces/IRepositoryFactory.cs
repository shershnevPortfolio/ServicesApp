using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Entities;
using ServicesApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Infrastructure.Abstractions.Interfaces
{
    internal interface IRepositoryFactory<TContext> where TContext : ApplicationContext
    {
        IRepository<TEntity> CreateRepositoryFor<TEntity>(TContext context) where TEntity : BaseEntity;

    }
}
