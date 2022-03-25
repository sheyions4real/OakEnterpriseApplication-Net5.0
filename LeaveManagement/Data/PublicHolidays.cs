using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Data
{
    public class PublicHolidays: BaseEntity
    {
      
        public int Title { get; set; }

        public int Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int NumOfWorkingDays { get; set; }
        public int Period { get; set; }

    }
}
