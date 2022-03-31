using AutoMapper;
using AutoMapper.QueryableExtensions;
using LeaveManagement.Common.Constants;
using LeaveManagement.Application.Contracts;
using LeaveManagement.Data;
using LeaveManagement.Common.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Application.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly UserManager<Employee> userManager;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;
        private readonly IConfigurationProvider configurationProvider;
        private readonly IEmailSender emailSender;
        private readonly IMapper mapper;
        private readonly IDepartmentRepository departmentRepository;
        private readonly IEmployeeProfileRepository employeeProfileRepository;
        private readonly ApplicationDbContext context;


        public LeaveRequestRepository(ApplicationDbContext context,
            IEmployeeProfileRepository employeeProfileRepository,
            IDepartmentRepository departmentRepository,
            UserManager<Employee> userManager,
            IHttpContextAccessor httpContextAccessor,
            ILeaveAllocationRepository leaveAllocationRepository,
            IConfigurationProvider configurationProvider,
            IEmailSender emailSender,
            IMapper mapper) : base(context)
        {
            this.userManager = userManager;
            this.httpContextAccessor = httpContextAccessor;
            this.leaveAllocationRepository = leaveAllocationRepository;
            this.configurationProvider = configurationProvider;
            this.emailSender = emailSender;
            this.mapper = mapper;
            this.employeeProfileRepository = employeeProfileRepository;
            this.departmentRepository = departmentRepository;
            this.context = context;
        }



        public async Task<List<Employee>> GetSupervisors()
        {
            var supervisors = await userManager.GetUsersInRoleAsync(Roles.Supervisor);
            return supervisors.ToList();
        }


        public List<EmployeeProfile> GetEmployeesByDepartment(string departmentId)
        {
            var myTeam = context.Staff.Where(q => q.DepartmentID == departmentId && q.Status == 1);
            return myTeam.ToList();
        }

        public async Task<List<Employee>> GetGroupHead()
        {
            var groupHeads = await userManager.GetUsersInRoleAsync(Roles.Group_Head);
            return groupHeads.ToList();
        }


        public async Task<List<Employee>> GetHRList()
        {
            var Hr = await userManager.GetUsersInRoleAsync(Roles.HR);
            return Hr.ToList();
        }


        public async Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model)
        {
            //get the current user
            var user = await userManager.GetUserAsync(httpContextAccessor?.HttpContext?.User);
            // var hrUserList = await userManager.GetUsersInRoleAsync(Roles.HR);
            var hrUserList = await employeeProfileRepository.GetUsersInRole(Roles.HR);
            var EDUserList = await employeeProfileRepository.GetUsersInRole(Roles.ED);
            var MDUserList = await employeeProfileRepository.GetUsersInRole(Roles.MD);

           // hrUserList.Add(new EmployeeProfileVM { Id = "9300525d-28cf-43f6-834d-6cf16eb2050f" });
            var allocation = await leaveAllocationRepository.GetEmployeeAllocation(user.Id, model.LeaveTypeId);
            if (allocation == null)
            {
                return false;
            }
            // check with days left
            if (model.TotalDaysRequested > ((allocation.DaysAllocated + allocation.DaysBroughtForward) - allocation.DaysUsed))
            {
                return false;
            }


            var leaveRequest = mapper.Map<LeaveRequest>(model);
            leaveRequest.DateRequested = DateTime.Now;
            leaveRequest.HREmployeeId = hrUserList.Count > 0 ? hrUserList[0].Id : "";
            leaveRequest.EDEmployeeId = EDUserList.Count > 0 ? EDUserList[0].Id : "";
            leaveRequest.MDEmployeeId = MDUserList.Count > 0 ? MDUserList[0].Id : "";
            leaveRequest.EmployeeId = user.Id;

            await AddAsync(leaveRequest);

            await emailSender.SendEmailAsync(user.Email, "Leave Submitted Successfully", $"Your Leave application for {leaveRequest.StartDate.ToShortDateString()} and to resume on {leaveRequest.EndDate.ToShortDateString()}. has been submitted successfully");
           
            var supervisor = await userManager.FindByIdAsync(leaveRequest.SupervisorEmployeeId);
            if (supervisor != null)
            {
                await emailSender.SendEmailAsync(supervisor.Email, "Leave Request Approval", $"A Leave Request has been submitted for {user.Firstname} {user.Lastname} to commence on {leaveRequest.StartDate.ToShortDateString()} and to resume on {leaveRequest.EndDate.ToShortDateString()}. Please login and update accordingly");
            }


            var hrEmployee = await userManager.FindByIdAsync(leaveRequest.HREmployeeId);
            if (supervisor != null)
            {
               // await emailSender.SendEmailAsync(hrEmployee.Email, "Leave Request Approval", $"A Leave Request has been submitted for {user.Firstname} {user.Lastname} to commence on {leaveRequest.StartDate.ToShortDateString()} and to resume on {leaveRequest.EndDate.ToShortDateString()}. Please login and update accordingly");
            }


            var grouphead = await userManager.FindByIdAsync(leaveRequest.GroupHeadEmployeeId);
            if (supervisor != null)
            {
                await emailSender.SendEmailAsync(grouphead.Email, "Leave Request Approval", $"A Leave Request has been submitted for {user.Firstname} {user.Lastname} to commence on {leaveRequest.StartDate.ToShortDateString()} and to resume on {leaveRequest.EndDate.ToShortDateString()}. Please login and update accordingly");
            }

            // can send email here
            return true;

        }


        public async Task<EmployeeLeaveRequestVM> GetMyLeaveDetails(string Id) {

            var user = new Employee();
            if (Id == null || Id == ""){
                 user = await userManager.GetUserAsync(httpContextAccessor?.HttpContext?.User);
            }
            else
            {
                user.Id = Id;
            }
            //get the current user
           

            var allocations = (await leaveAllocationRepository.GetEmployeeAllocations(user.Id)).LeaveAllocations;
            var request = await GetAllAsync(user.Id); //  mapper.Map<List<LeaveRequestVM>>(await GetAllAsync(user.Id)); // does not require mapping again since the method already uses ProjectTo to return the LeaveRequestVM model 
            var employee =  mapper.Map <EmployeeProfileVM>(await employeeProfileRepository.GetEmployeeProfile(user.Id));

            var viewModel = new EmployeeLeaveRequestVM(allocations, request , employee);
           
            return viewModel;
        }

        public async Task<List<LeaveRequestVM>> GetAllAsync(string Id)
        {
            return await context.LeaveRequests
                .Where(q => q.EmployeeId == Id)
                .ProjectTo<LeaveRequestVM>(configurationProvider) // return the Leave requests in LeaveRequestVM model
                .ToListAsync();
        }

        public async Task<AdminLeaveRequestVM> GetAdminLeaveRequestVM()
        {
            // get all leave requests inner join leavetype
            var leaveRequests = await context.LeaveRequests.Include(q=> q.LeaveType).ToListAsync();
            var model = new AdminLeaveRequestVM
            {
                TotalRequests = leaveRequests.Count,
                ApprovedRequest = leaveRequests.Count(q => q.Approved == true),
                PendingRequests = leaveRequests.Count(q => q.Approved == null),
                RejectedRequests = leaveRequests.Count(q => q.Approved == false),
                LeaveRequests = mapper.Map<List<LeaveRequestVM>>(leaveRequests)
            };

            foreach (var employee in model.LeaveRequests)
            {
                employee.Employee = await employeeProfileRepository.GetEmployeeProfile(employee.EmployeeId);
                var reliever = await employeeProfileRepository.GetEmployeeProfile(employee.RelieverID);
                employee.RelieverName = reliever.Lastname + " " + reliever.Firstname;
            }

            return model;
        }

        public async Task ChangeLeaveRequestStatus(int leaveRequestId, LeaveRequestVM leaveRequest )
        {
            // var leaveRequest = await GetAsync(leaveRequestId);
            //if(role == Roles.Supervisor)
            //{
            //    leaveRequest.SupervisorApproval = approved;
            //}
            //if (role == Roles.HR)
            //{
            //    leaveRequest.HRApproval = approved;
            //}
            //if(role == Roles.Group_Head)
            //{
            //    leaveRequest.GroupHeadApproval = approved;
            //}
            //if(role == Roles.ED)
            //{
            //    leaveRequest.EDApproval = approved;
            //}
            //if (role == Roles.MD)
            //{
            //    leaveRequest.MDApproval = approved;
            //}
            var user = await userManager.FindByIdAsync(leaveRequest.EmployeeId);

            if (leaveRequest.SupervisorApproval == false || leaveRequest.HRApproval == false || leaveRequest.GroupHeadApproval == false || leaveRequest.EDApproval == false || leaveRequest.HRApproval == false || leaveRequest.MDApproval == false)
            {
                leaveRequest.Approved = false;
            }

            if (leaveRequest.SupervisorApproval != null && leaveRequest.HRApproval != null && leaveRequest.GroupHeadApproval != null && leaveRequest.EDApproval != null && leaveRequest.HRApproval != null && leaveRequest.MDApproval != null)
            {
                if (leaveRequest.SupervisorApproval.Value && leaveRequest.HRApproval.Value && leaveRequest.GroupHeadApproval.Value && leaveRequest.EDApproval.Value && leaveRequest.HRApproval.Value && leaveRequest.MDApproval.Value)
                {
                    leaveRequest.Approved = true;
                }
                else
                {
                    leaveRequest.Approved = false;
                }
            }

            if (leaveRequest.Approved == true )
            {
                // fetch the leave allocation for the user with the leavetype
                var allocation = await leaveAllocationRepository.GetEmployeeAllocation(leaveRequest.EmployeeId, leaveRequest.LeaveTypeId);

                // int daysRequested = (int)(leaveRequest.EndDate - leaveRequest.StartDate).TotalDays;
                int daysApplicable = (allocation.DaysAllocated + allocation.DaysBroughtForward) - allocation.DaysUsed;
                if(daysApplicable >= leaveRequest.TotalDaysRequested)
                {
                    allocation.DaysUsed = allocation.DaysUsed + leaveRequest.TotalDaysRequested;
                }
                else
                {
                    leaveRequest.Approved = false;
                }

                await leaveAllocationRepository.UpdateAsync(allocation);

                // send email that leave has been approved
               
                await emailSender.SendEmailAsync(user.Email, "Leave Has Been Approved", @"Your Leave has been approved. You are to commence on " + leaveRequest.StartDate.ToString() + " and to resume on " + leaveRequest.EndDate + ". \nPlease Ensure to hand over properly");
            }else if(leaveRequest.Approved == false)
            {
                await emailSender.SendEmailAsync(user.Email, "Leave Has Been Rejected", @"Your Leave has been Rejected. You are not to commence on " + leaveRequest.StartDate.ToString() + " to " + leaveRequest.EndDate + ". \nPlease Login to review reasons");
            }

            await UpdateAsync(mapper.Map<LeaveRequest>(leaveRequest));
        }


        public async Task<LeaveRequestVM> GetLeaveReqyestAsync(int? Id)
        {
            var leaveRequests = await context.LeaveRequests.Include(q => q.LeaveType).FirstOrDefaultAsync(q => q.Id == Id);
            if(leaveRequests == null)
            {
                return null;
            }

            var model = mapper.Map<LeaveRequestVM>(leaveRequests);
            model.Employee = await employeeProfileRepository.GetEmployeeProfile(leaveRequests.EmployeeId);
            return model;
        }

        public async Task CancelLeaveRequest(int leaveRequestId)
        {
            var leaveRequest = await GetAsync(leaveRequestId);
            leaveRequest.Cancelled = true;
            await UpdateAsync(leaveRequest);
            var user = await userManager.FindByIdAsync(leaveRequest.EmployeeId);
            await emailSender.SendEmailAsync(user.Email, "Leave Has Been Cancelled", @"Your Leave Applicaion from  " + leaveRequest.StartDate.ToString() + " to " + leaveRequest.EndDate + " has been Cancelled. ");
        }
    }
}
