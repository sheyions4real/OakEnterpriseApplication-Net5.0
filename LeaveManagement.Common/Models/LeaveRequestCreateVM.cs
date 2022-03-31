using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace LeaveManagement.Common.Models
{
    public class LeaveRequestCreateVM : IValidatableObject
    {
       // public string EmployeeId { get; set; }


       
      [Required]
        public int LeaveTypeId { get; set; }

        
        [Display(Name ="Select Leave Type")]
        public SelectList LeaveTypes { get; set; }




        [Required]
        [Display(Name = "Number of Days Requested")]
        [Range(1,20)]
        public int TotalDaysRequested { get; set; }


        [Range(0, 3)]
        [Display(Name = "Public Holiday Applicable ")]
        public int TotalPublicHolidays { get; set; } = 0;

        

        [Display(Name = "Total Days Outstanding")]
        [Range(0, 20)]
        public int TotalOutstanding { get; set; } = 0;


        
        [Display(Name = "Leave Year")]
        public int LeaveYear { get; set; } = DateTime.Now.Year;
        [Display(Name = "Select Leave Year")]
        public SelectList LeaveYearList { get; set; }





        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Start Date")] 
        [Required]
        public DateTime? StartDate { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "End Date")] 
        [Required]
        public DateTime? EndDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Request Date")]
        public DateTime? DateRequested { get; set; }

        [Display(Name = "Leave Reliever ")]
        public string RelieverID { get; set; }

        [Display(Name = "Reliever Details")]
        public string RelieverName { get; set; }

        [Display(Name = "Select Reliever")]
        public SelectList Relievers { get; set; }

        [Required]
        [Display(Name = "Leave Comment")]
        public string? Comment { get; set; }


        [Display(Name = "Supervisor")]
        public string SupervisorEmployeeId { get; set; }

      
        [Display(Name = "Select Supervisor")]
        public SelectList Supervisors { get; set; }

        [Display(Name = "Group Head")]
        public string GroupHeadEmployeeId  { get; set; }

   
        [Display(Name = "Select Group Head")]
        public SelectList GroupHeads { get; set; }


        [Display(Name = "HR Manager")]
        public string HREmployeeId { get; set; }

        [Display(Name = "Select HR")]
        public SelectList HREmployeeList { get; set; }


        [Display(Name = "ED")]
        public string EDEmployeeId { get; set; }
        [Display(Name = "Select ED")]
        public SelectList EDEmployeeList { get; set; }


        [Display(Name = "MD")]
        public string MDEmployeeId { get; set; }
        [Display(Name = "Select Group Head")]
        public SelectList MDEmployeeList { get; set; }





        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            Debug.Write("----------------------------");
            Debug.Write("TEST TEST TEST");
            Debug.Write("----------------------------");

            //the yield will enable multiple return in the method 
            // Add Custom Validation
            // instead of adding validation rules to the controller
            if (RelieverID == "Select Reliever")
            {
                yield return new ValidationResult("Select Reliever", new[] { nameof(Relievers) });
            }

            if (StartDate < DateTime.Now)
            {
                yield return new ValidationResult("The Start Date must be After today", new[] { nameof(StartDate) });
            }

            if (StartDate > EndDate)
            {
                yield return new ValidationResult("The Start Date must be before the end date", new[] { nameof(StartDate), nameof(EndDate)});
            }

            if (Comment.Length > 250)
            {
                yield return new ValidationResult("The Comment should not be more than 250 characters", new[] { nameof(Comment) });
            }
        }

        //public bool? Approved { get; set; }
        //public bool Cancelled { get; set; }  // if the employeee cancelled the leave
    }
}
