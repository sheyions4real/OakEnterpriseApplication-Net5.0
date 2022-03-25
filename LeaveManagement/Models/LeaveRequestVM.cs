using LeaveManagement.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Models
{
    public class LeaveRequestVM : LeaveRequestCreateVM
    {

        public int  Id { get; set; }
        [Display(Name = "Employee")]
        public string EmployeeId { get; set;}
       
      
        [Display(Name = "Leave Type")]
        public LeaveTypeVM LeaveType { get; set; }

        public EmployeeProfile Reliever { get; set; }



        public EmployeeProfile SupervisorEmployee { get; set; }

        [Display(Name = "Supervisor Approval")]
        public bool? SupervisorApproval { get; set; }

        [Display(Name = "Supervisor Comment")]
        public string SupervisorComment { get; set; }


       
        public EmployeeProfile HREmployee { get; set; }
        [Display(Name = "HR Manager")]
        public string HREmployeeId { get; set; }


        [Display(Name = "HR Approval")]
        public bool? HRApproval { get; set; }

        [Display(Name = "HR Comment")]
        public string HRComment { get; set; }


      
        public EmployeeProfile GroupHeadEmployee { get; set; }



        [Display(Name = "Group Head Approval")]
        public bool? GroupHeadApproval { get; set; }

        [Display(Name = "Group Head Comment")]
        public string GHComment { get; set; }


     
        public EmployeeProfile EDEmployee { get; set; }
        [Display(Name = "EDl")]

        public string EDEmployeeId { get; set; }

        [Display(Name = "ED Approval")]
        public bool? EDApproval { get; set; }

        [Display(Name = "ED Comment")]
        public string EDComment { get; set; }

       

        public EmployeeProfile MDEmployee { get; set; }

        [Display(Name = "MD")]
        public string MDEmployeeId { get; set; }

        [Display(Name = "MD Approval")]
        public bool? MDApproval { get; set; }

        [Display(Name = "MD Comment")]
        public string MDComment { get; set; }



        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }  // if the employeee cancelled the leave


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Date Modified")]
        public DateTime DateModified { get; set; }



        public EmployeeProfile Employee { get; set; }

        public EmployeeProfile LoggedInUser  { get; set; }
    }
}
