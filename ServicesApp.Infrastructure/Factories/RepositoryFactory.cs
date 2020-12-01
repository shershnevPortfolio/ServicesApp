using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Entities;
using ServicesApp.Infrastructure.Abstractions.Interfaces;
using ServicesApp.Infrastructure.Data;
using ServicesApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Infrastructure.Factories
{
    class RepositoryFactory<TContext> : IRepositoryFactory<TContext> where TContext : ApplicationContext
    {
        public IRepository<TEntity> CreateRepositoryFor<TEntity>(TContext context) where TEntity : BaseEntity
        {
            return new BaseRepository<TEntity>(context);
        }
    }
}
