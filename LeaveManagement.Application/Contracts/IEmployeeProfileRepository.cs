using LeaveManagement.Common.Models;
using LeaveManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Application.Contracts
{
    public interface IEmployeeProfileRepository : IGenericRepository<EmployeeProfile>
    {
        Task<EmployeeProfileVM> GetEmployeeProfile(string id);

        public  Task<List<EmployeeProfileVM>> GetUsersInRole(string role);
        
    }
}
