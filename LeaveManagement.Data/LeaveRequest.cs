using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Data
{
    public class LeaveRequest: BaseEntity
    {
        [ForeignKey("EmployeeId")]
        public EmployeeProfile Employee { get; set; }
        public string EmployeeId { get; set; }


        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }


        public int TotalDaysRequested { get; set; }
        public int TotalPublicHolidays { get; set; }
        public int TotalOutstanding { get; set; }
        public int LeaveYear { get; set; }


        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public DateTime DateRequested { get; set; }


        [ForeignKey("RelieverID")]
        public EmployeeProfile Reliever { get; set; }
        public string RelieverID { get; set; }




        public string? Comment { get; set; }

        [ForeignKey("SupervisorEmployeeId")]
        public EmployeeProfile SupervisorEmployee { get; set; }
        public string SupervisorEmployeeId { get; set; }



        public bool? SupervisorApproval { get; set; }
        public string SupervisorComment { get; set; }


        [ForeignKey("HREmployeeId")]
        public EmployeeProfile HREmployee { get; set; }
        public string HREmployeeId { get; set; }



        public bool? HRApproval { get; set; }
        public string HRComment { get; set; }


        [ForeignKey("GroupHeadEmployeeId")]
        public EmployeeProfile GroupHeadEmployee { get; set; }
        public string GroupHeadEmployeeId { get; set; }



        public bool? GroupHeadApproval { get; set; }
        public string GHComment { get; set; }


        [ForeignKey("EDEmployeeId")]
        public EmployeeProfile EDEmployee { get; set; }
        public string EDEmployeeId { get; set; }


        public bool? EDApproval { get; set; }
        public string EDComment { get; set; }

        [ForeignKey("MDEmployeeId")]
        public EmployeeProfile MDEmployee { get; set; }
        public string MDEmployeeId { get; set; }



        public bool? MDApproval { get; set; }
        public string MDComment { get; set; }




        public bool? Approved { get; set; }   
        public bool Cancelled { get; set; }  // if the employeee cancelled the leave

    }
}
