using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Data
{
    public class Department 
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string HOD { get; set; }
        public int Number_Of_Staff { get; set; }
        public int Number_Of_Units { get; set; }
        public string Units { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

    }
}
