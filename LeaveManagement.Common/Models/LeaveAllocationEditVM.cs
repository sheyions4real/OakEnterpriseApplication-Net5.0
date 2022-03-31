
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Common.Models
{
    public class LeaveAllocationEditVM: LeaveAllocationVM
    {
      
        public int LeaveTypeId { get; set; }
        public EmployeeProfileVM Employee { get; set; }
    }
}
