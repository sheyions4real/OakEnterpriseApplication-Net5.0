using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Common.Constants
{
    public static class Roles
    {
        public const string Administrator = "Administrator";
        public const string Supervisor = "Supervisor";
        public const string Group_Head = "Group Head"; 
        public const string HR = "HR";
        public const string MD = "MD";
        public const string ED = "ED";
        public const string User = "User";

        public  const string admin_And_HR = Administrator + "," + HR;
        public const string allApproval = Administrator + "," + HR + "," + Supervisor + "," + Group_Head + "," + ED + "," + MD;
        public static string[] allApprover = { Administrator, HR, Supervisor, Group_Head, ED, MD };
        
    }

    
}
