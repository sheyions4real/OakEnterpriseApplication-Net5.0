using LeaveManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Contracts
{
    public interface IEmployeeProfileRepository : IGenericRepository<EmployeeProfile>
    {
        Task<EmployeeProfile> GetEmployeeProfile(string id);

        public  Task<List<Employee>> GetUsersInRole(string role);
        
    }
}
