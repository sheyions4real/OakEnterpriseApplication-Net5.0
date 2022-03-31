using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Common.Models
{
    public class PublicHolidayVM
    {

        public int Id { get; set; }

        [Display(Name = "Holiday Title")]
        public int Title { get; set; }

        [Display(Name = "Holiday Description")]
        public int Description { get; set; }

        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Number of Working Days")]
        public int NumOfWorkingDays { get; set; }

        [Display(Name = "Period")]
        public int Period { get; set; }
    }
}
