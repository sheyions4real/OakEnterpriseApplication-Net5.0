using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Common.Models
{
    public class AdminLeaveRequestVM
    {
        [Display(Name="Total Leave Request")]
        public int TotalRequests { get; set; }


        [Display(Name = "Approved Request")]
        public int ApprovedRequest { get; set; }

        [Display(Name = "Pending Request")]
        public int PendingRequests { get; set; }

        [Display(Name = "Rejected Request")]
        public int RejectedRequests { get; set; }

        [Display(Name = "Staff On Leave")]
        public int StaffOnLeave { get; set; }

        [Display(Name = "Due For Leave")]
        public int StaffDueThisMonth { get; set; }

        [Display(Name = "Yet To Apply")]
        public int YetToApply { get; set; }

        [Display(Name = "Total Active Staff")]
        public int ActiveStaff { get; set; }

        [Display(Name = "Total Supervisors")]
        public int TotalSupervisor { get; set; }

        [Display(Name = "Total HR")]
        public int TotalHR { get; set; }

        [Display(Name = "Total Group Head")]
        public int TotalGroupHead { get; set; }

        [Display(Name = "Total Staff Un-Allocated")]
        public int TotalUnAllocated { get; set; }

        [Display(Name = "Next Holiday")]
        public PublicHolidayVM Holiday { get; set; }



        public List<LeaveRequestVM> LeaveRequests { get; set; }

    }
}
