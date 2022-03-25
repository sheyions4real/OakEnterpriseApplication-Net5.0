using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Models
{
    public class EmployeeLeaveRequestVM
    {

        public List<LeaveAllocationVM> LeaveAllocations { get; set; }
        public List<LeaveRequestVM> LeaveRequests { get; set; }
        public EmployeeProfileVM Employee { get; set; }
        public EmployeeLeaveRequestVM(List<LeaveAllocationVM> leaveAllocations, List<LeaveRequestVM> leaveRequests, EmployeeProfileVM employee)
        {
           
            this.LeaveAllocations = leaveAllocations;
            this.LeaveRequests = leaveRequests;
            this.Employee = employee;
        }

       


    }
}
