using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Application.Contracts
{
    // generics using Type T which will serve as a variable
    // to declare an interface that will handle CRUD
    public interface IGenericRepository<T> where T :class
    {
        Task<T?> GetAsync(int? id);
        Task<List<T>> GetAllAsync(); 
        Task<T> AddAsync(T entity);
        // Task<T> GetCountAsync();

        Task AddRangeAsync(List<T> entities);

        Task<bool> Exists(int id);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);
       
    }
}
