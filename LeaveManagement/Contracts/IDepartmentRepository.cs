using LeaveManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Contracts
{
    public interface IDepartmentRepository : IGenericRepository<Department>
    {
        public Task<string> GetDepartmentName(string id);
    }
}
