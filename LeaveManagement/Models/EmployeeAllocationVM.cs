using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Models
{
    public class EmployeeAllocationVM : EmployeeProfileVM
    {
        public List<LeaveAllocationVM> LeaveAllocations { get; set; }
    }
}
