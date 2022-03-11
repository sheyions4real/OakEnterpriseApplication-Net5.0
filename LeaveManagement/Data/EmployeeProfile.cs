using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Data
{
    public class EmployeeProfile : IdentityUser
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
        public string branch { get; set; }
        public string Rsa_Pin { get; set; }
        public int Status { get; set; }





    }
}
