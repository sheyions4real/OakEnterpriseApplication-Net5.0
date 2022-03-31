using LeaveManagement.Data;
using LeaveManagement.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Application.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        // custom interface  in additional to the ones inherited from the IGenericRepository

        Task LeaveAllocation(int leaveType);

        Task<bool> AllocationExists(string staffId, int leaveTypeId, int period);


        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);
        Task<LeaveAllocation?> GetEmployeeAllocation(string employeeId , int leaveTypeId);

        Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id);

        Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model);
    }
}
