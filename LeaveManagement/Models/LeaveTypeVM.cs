using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Models
{
    public class LeaveTypeVM
    {
        private const string V = "Default Number of Days";

        public int Id { get; set; }
        [Display(Name="Leave Type")]
        [Required]
        public string Name { get; set; }
        [Display(Name =V)]
        [Required]
        [Range(1,25,ErrorMessage = "Please Enter A Valid Number")]
        public int DefaultDays { get; set; }
      
    }
}
