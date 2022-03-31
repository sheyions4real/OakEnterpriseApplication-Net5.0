//using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Common.Models
{
    public class EmployeeVM
    {
        [Key]
        public string Id { get; set; }
        [Display(Name = "First Name")]
        public string Firstname { get; set; }
        [Display(Name = "Last Name")]

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public string Lastname { get; set; }
        [Display(Name = "Date Employed")]
        public string DateEmployed { get; set; }
    }


    public class UserByRoles
    {
      
        public List<EmployeeVM> Users{ get; set; }
        public List<EmployeeVM> Supervisors { get; set; }
        public List<EmployeeVM> HR { get; set; }
    }


    public class EmployeeProfileVM :  IdentityUser
    {
        [Key]
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Othernames { get; set; }
        public string DepartmentID { get; set; }
        public SelectList Departments { get; set; }


        public string Title { get; set; }
        public string Address1 { get; set; }

        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public string Marital_Status { get; set; }
        public string Mobile_Phone { get; set; }
        public string Level_Of_Entry { get; set; }
 
        public string Position { get; set; }
        public SelectList Positions { get; set; }

        public string branch { get; set; }
        public string Rsa_Pin { get; set; }
        public int Status { get; set; }


        public string Confirmed { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? DateEmployed { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? DateConfirmed { get; set; }





        public string? TaxID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? DateOfBirth { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? DateCreated { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? DateUpdated { get; set; }

    }
    

}
