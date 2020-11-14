using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ServicesApp.Core.Interfaces;
using ServicesApp.Core.Entities;
using ServicesApp.Infrastructure.Data;
using System.Threading.Tasks;

namespace ServicesApp.Infrastructure.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T: BaseEntity
    {
        private readonly ApplicationContext _context;
        protected readonly DbSet<T> _entities;
        public BaseRepository(ApplicationContext context)
        {
            _context = context;
            _entities = context.Set<T>();

        }

        public IAsyncEnumerable<T> GetAll()
        {
            return  _entities.AsAsyncEnumerable();
        }

        public async Task<T> GetById(int id)
        {
            return await _entities.FindAsync(id).AsTask();
        }

        public async Task Add(T entity)
        {
           await _entities.AddAsync(entity);
        }
        
        public void Update(T entity)
        {
            _entities.Update(entity);
        }

        public async Task Delete(int id)
        {
            T entity = await GetById(id);

            _entities.Remove(entity);
        }

    }
}
