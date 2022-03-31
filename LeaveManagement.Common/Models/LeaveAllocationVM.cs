using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Common.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }
       
        [Required]
        [Display(Name = "Employee ID")]
        public string EmployeeId { get; set; }


        [Display(Name = "Day Alocated")]
        [Required]
        [Range(1,25, ErrorMessage ="Can only allocate 1 to 25 days")]
        public int DaysAllocated { get; set; }


        [Display(Name = "Days Used")]
        [Required]
        public int DaysUsed { get; set; }


        [Display(Name = "Public Holidays")]
        [Required]
        public int PublicHolidays { get; set; }

        [Display(Name = "Day Brought Forward")]
        [Required]
        public int DaysBroughtForward { get; set; }

        [Display(Name = "Allocation Year")]
        [Required]
        public int Period { get; set; }

        public LeaveTypeVM LeaveType { get; set; }


    }
}