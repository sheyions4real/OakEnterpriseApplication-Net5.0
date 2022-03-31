using LeaveManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Application.Contracts
{
    public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
    {
        // specific and custom operations for LeaveType
    }
}
