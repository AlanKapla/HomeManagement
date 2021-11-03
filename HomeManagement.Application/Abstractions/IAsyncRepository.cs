using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeManagement.Application.Abstractions
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();

        Task<T> AddAsync(T entity);

        Task<T> DeleteAsync(T entity);

        Task<T> UpdateAsync(T entity);
    }
}
