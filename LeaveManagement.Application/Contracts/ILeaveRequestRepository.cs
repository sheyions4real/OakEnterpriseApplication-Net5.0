using LeaveManagement.Data;
using LeaveManagement.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Application.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        public List<EmployeeProfile> GetEmployeesByDepartment(string departmentId);
        public Task<List<Employee>> GetSupervisors();

        public Task<List<Employee>> GetGroupHead();

        public  Task<List<Employee>> GetHRList();

        public Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model);

        public Task<EmployeeLeaveRequestVM> GetMyLeaveDetails(string Id);
        public Task<List<LeaveRequestVM>> GetAllAsync(string Id);

        public Task<LeaveRequestVM?> GetLeaveReqyestAsync(int? Id);
        public Task<AdminLeaveRequestVM> GetAdminLeaveRequestVM();

        public Task ChangeLeaveRequestStatus(int leaveRequestId, LeaveRequestVM leaveRequest);


        public Task CancelLeaveRequest(int leaveRequestId); 

    }
}
