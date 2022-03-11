using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Models
{
    public class EmployeeVM
    {
        [Key]
        public string Id { get; set; }
        [Display(Name = "First Name")]
        public string Firstname { get; set; }
        [Display(Name = "Last Name")]
        public string Lastname { get; set; }
        [Display(Name = "Date Employed")]
        public string DateEmployed { get; set; }
    }

    [Keyless]
    public class UserByRoles
    {
      
        public List<EmployeeVM> Users{ get; set; }
        public List<EmployeeVM> Supervisors { get; set; }
        public List<EmployeeVM> HR { get; set; }
    }


    public class EmployeeProfileVM
    {
        [Key]
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Othernames { get; set; }
        public string DepartmentID { get; set; }
        public string DateEmployed { get; set; }
        public string DateConfirmed { get; set; }
    }

}
