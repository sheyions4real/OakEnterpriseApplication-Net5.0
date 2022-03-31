using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Common.Models
{

    // with abstract class the class cant be instiantiated
    public abstract class BaseEntity
    {
        public string Id { get; set; } // automatically will be the identity column
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
