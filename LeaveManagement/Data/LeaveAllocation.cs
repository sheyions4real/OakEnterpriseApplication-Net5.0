using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Data
{
    public class LeaveAllocation :BaseEntity
    {
      
        public int DaysAllocated { get; set; }
        public int DaysUsed { get; set; }
        public int PublicHolidays { get; set; }
        public int DaysBroughtForward { get; set; }
        // a foregin key field
        [ForeignKey("LeaveTypeId")] 
        public LeaveType LeaveType { get; set; } // The table name as type to denote foreign key 
        public int LeaveTypeId { get; set; } // The class name and id to denote foreign key


        public string EmployeeId { get; set; } 
        public int Period { get; set; }
        public DateTime? Start_Date { get; set; }
        public DateTime? End_Date { get; set; }

    }
}
