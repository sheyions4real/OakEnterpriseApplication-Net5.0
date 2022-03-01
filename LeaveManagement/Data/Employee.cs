using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Data
{
    public class Employee:IdentityUser
    {
        // this class will inherit all properties  from identityUser

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string DepartmentID { get; set; }
        public string? TaxID { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string DateEmployed { get; set; }
        public string Confirmed { get; set; }
        public DateTime? DateConfirmed { get; set; }
    }
}
