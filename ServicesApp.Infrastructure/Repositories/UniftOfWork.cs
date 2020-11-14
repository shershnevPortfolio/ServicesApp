using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ServicesApp.Core.Interfaces;
using ServicesApp.Infrastructure.Data;

namespace ServicesApp.Infrastructure.Repositories
{
    class UniftOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationContext _context;

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
            _context.SaveChangesAsync();
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
