using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Models
{
    public class LeaveRequestEdit
    {
        public string EmployeeId { get; set; }


      
        public SelectList LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "End Date")]

        public DateTime EndDate { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Date Requested")]

        public DateTime DateRequested { get; set; }

        
        [Display(Name = "Reliever")]
        public string RelieverID { get; set; }

        public string Comment { get; set; }


        [Display(Name = "Supervisor")]
        public string SupervisorEmployeeId { get; set; }

        [Display(Name = "Supervisor Approval")]
        public bool? SupervisorApproval { get; set; }


        [Display(Name = "Supervisor Comment")]
        public string SupervisorComment { get; set; }


        [Display(Name = "HR")]
        public string HREmployeeId { get; set; }

        [Display(Name = "HR Approval")]
        public bool? HRApproval { get; set; }

        [Display(Name = "HR Comment")]
        public string HRComment { get; set; }


        [Display(Name = "Group Head")]
        public string GroupHeadEmployeeId { get; set; }

        [Display(Name = "Group Head Approval")]
        public bool? GroupHeadApproval { get; set; }

        [Display(Name = "Group Head Comment")]
        public string GHComment { get; set; }


        [Display(Name = "ED")]
        public string EDEmployeeId { get; set; }


        [Display(Name = "ED Approval")]
        public bool? EDApproval { get; set; }


        [Display(Name = "MD Comment")]
        public string EDComment { get; set; }



        [Display(Name = "MD")]
        public string MDEmployeeId { get; set; }


        [Display(Name = "MD Approval")]
        public bool? MDApproval { get; set; }


        [Display(Name = "MD Comment")]
        public string MDComment { get; set; }




        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }  // if the employeee cancelled the leave
    }
}
