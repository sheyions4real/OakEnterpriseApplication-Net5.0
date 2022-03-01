using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Data
{
    public class LeaveAllocation
    {
        public int Id { get; set; } // automatically will be the identity column
        public int NumberOfDays { get; set; }

        // a foregin key field
        [ForeignKey("LeaveTypeId")] 
        public LeaveType LeaveType { get; set; } // The table name as type to denote foreign key 
        public int LeaveTypeId { get; set; } // The class name and id to denote foreign key


       
        public string EmployeeId { get; set; } 
      


        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
