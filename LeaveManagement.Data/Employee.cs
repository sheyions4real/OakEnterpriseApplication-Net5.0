using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Data
{
    public class Employee:IdentityUser 
    {
        // this class will inherit all properties  from identityUser

        public string Firstname { get; set; }
        public string Othernames { get; set; }
        public string Lastname { get; set; }
        public string DepartmentID { get; set; }
        public string? TaxID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{MM/dd/yyyy}")]
        public DateTime? DateOfBirth { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{MM/dd/yyyy}")]
        public DateTime? DateEmployed { get; set; }
        public string Confirmed { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{MM/dd/yyyy}")]
        public DateTime? DateConfirmed { get; set; }


        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }







    }
}
