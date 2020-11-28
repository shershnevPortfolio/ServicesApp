using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ServicesApp.Core.Abstractions.Commands;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Entities;
using ServicesApp.Infrastructure.Data;

namespace ServicesApp.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationContext _context;

        private readonly ICategoryRepository _categoryRepository;

        private readonly IRepository<SubCategory> _subCategoryRepository;

        public ICategoryRepository CategoryRepository => _categoryRepository ?? new CategoryRepository(_context);

        public IRepository<SubCategory> SubCategoryRepository => _subCategoryRepository ?? new BaseRepository<SubCategory>(_context);

        public UnitOfWork(ApplicationContext conext)
        {
            _context = conext;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public Task ExecuteCrudCommand(CrudCommand command) 
        {
            throw new NotImplementedException();    
        }

        public void Dispose()
        {
            if(_context != null)
            {
                _context.Dispose();
            }
        }
    }
}
