using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ServicesApp.Core.Abstractions.Queries;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Entities;
using ServicesApp.Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;
using ServicesApp.Infrastructure.Abstractions.Interfaces;

namespace ServicesApp.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        
        private readonly ApplicationContext _context;

        private readonly IRepositoryFactory<ApplicationContext> _repositoryFactory;

        public UnitOfWork(ApplicationContext context, IServiceProvider serviseProvider)
        {
            _context = context;
            _repositoryFactory = serviseProvider.GetService<IRepositoryFactory<ApplicationContext>>();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            if(_context != null)
            {
                _context.Dispose();
            }
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity
        {
            return _repositoryFactory.CreateRepositoryFor<TEntity>(_context);
        }
    }
}
