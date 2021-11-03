using HomeManagement.Application.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeManagement.Persistance.EntityFramework.Repositories
{
    public class BaseRepository<T> : IAsyncRepository<T> where T : class
    {
        private HomeManagementDbContext _dbContext;

        public DbSet<T> DbSet
        {
            get
            {
                return _dbContext.Set<T>();
            }
        }

        public BaseRepository(HomeManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await DbSet.AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<T> DeleteAsync(T entity)
        {
            DbSet.Remove(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            DbSet.Update(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }
    }
}