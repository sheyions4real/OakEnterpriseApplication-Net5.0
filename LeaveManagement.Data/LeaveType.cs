using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Data
{
    public class LeaveType : BaseEntity
    {
        // inherits all the default properties from the base class
        public string Name { get; set; }
        public int DefaultDays { get; set; }
       


    }
}
