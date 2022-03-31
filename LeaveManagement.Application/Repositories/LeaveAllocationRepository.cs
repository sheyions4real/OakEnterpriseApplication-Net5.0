using AutoMapper;
using AutoMapper.QueryableExtensions;
using LeaveManagement.Common.Constants;
using LeaveManagement.Application.Contracts;
using LeaveManagement.Data;
using LeaveManagement.Common.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Application.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IEmployeeProfileRepository employeeProfileRepository;
        private readonly IDepartmentRepository departmentRepository;
        private readonly IConfigurationProvider configurationProvider;
        private readonly IEmailSender emailSender;

        //private readonly ILeaveAllocationRepository leaveAllocationRepository; // this will cause a circular dependency 
        private readonly IMapper mapper;

        public LeaveAllocationRepository(ApplicationDbContext context, 
            UserManager<Employee> userManager,
            ILeaveTypeRepository leaveTypeRepository,
            IEmployeeProfileRepository employeeProfileRepository,
            IDepartmentRepository departmentRepository,
            IConfigurationProvider configurationProvider,
            IEmailSender emailSender,
            //ILeaveAllocationRepository leaveAllocationRepository, // this will cause a circular dependency
            IMapper mapper ) : base(context)
        {
            this.context = context;
            this.userManager = userManager;
            this.leaveTypeRepository = leaveTypeRepository;
            this.employeeProfileRepository = employeeProfileRepository;
            this.departmentRepository = departmentRepository;
            this.configurationProvider = configurationProvider;
            this.emailSender = emailSender;
            //this.leaveAllocationRepository = leaveAllocationRepository;
            this.mapper = mapper;
        }




        public async Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id)
        {


            // will get the first record
                    var allocation = await context.LeaveAllocations
                        .Include(q => q.LeaveType)
/*Projection*/          .ProjectTo<LeaveAllocationEditVM>(configurationProvider) // with the ProjectTo you dont need automapper to map leaveAllcationEditVM to LeaveAllocation data model
                        .FirstOrDefaultAsync(q => q.Id == id);

//            // using like  select top 1 id, employeeid, daysallocated, daysused from 
//            var allocation2 = await context.LeaveAllocations
//                       .Include(q => q.LeaveType)
//                       .Select(q => new { q.Id, q.EmployeeId, q.DaysAllocated, q.DaysUsed })
///*Projection*/          .ProjectTo<LeaveAllocationVM>(configurationProvider) // with the ProjectTo you dont need automapper to map leaveAllcation to LeaveAllocationVM
//                       .FirstOrDefaultAsync(q => q.Id == id);
                      

            if (allocation == null)
            {
                return null;
            }
            var employee = await employeeProfileRepository.GetEmployeeProfile(allocation.EmployeeId);

            var leaveAllocationVM = mapper.Map<LeaveAllocationEditVM>(allocation);
            leaveAllocationVM.Employee = mapper.Map<EmployeeProfileVM>(employee);
            
            return leaveAllocationVM;

        }








        // check if allocation exist for the staff
        public async Task<bool> AllocationExists(string staffId, int leaveTypeId, int period)
        {
            // querying records by filter
            return await context.LeaveAllocations.AnyAsync(q => q.EmployeeId == staffId
                                                                && q.LeaveTypeId == leaveTypeId
                                                                && q.Period == period);
        }

        public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId)
        {
            // inner join leaveallocation and leavetype using the where clase to get the collections
           var allocations = await context.LeaveAllocations
                            .Include(q => q.LeaveType)   // inner join to get the foreign key details for leaveType
                            .Where(q => q.EmployeeId == employeeId).ToListAsync();

            var employee = await context.Staff.FindAsync(employeeId);
            if ( employee != null)
            {
                // get the deparment description
                employee.DepartmentID = await departmentRepository.GetDepartmentName(employee.DepartmentID);
            }


            EmployeeAllocationVM employeeAllocationVM = new EmployeeAllocationVM();
            employeeAllocationVM = mapper.Map<EmployeeAllocationVM>(employee);
            employeeAllocationVM.LeaveAllocations = mapper.Map<List<LeaveAllocationVM>>(allocations);
            

            return employeeAllocationVM;
        }

        public async Task LeaveAllocation(int leaveTypeId)
        {
            var userEmployees = await userManager.GetUsersInRoleAsync(Roles.User);
            var supervisors = await userManager.GetUsersInRoleAsync(Roles.Supervisor);
            var hrUsers = await userManager.GetUsersInRoleAsync(Roles.HR);

            List<EmployeeProfile> employeeAllocated = new List<EmployeeProfile>();


            var allStaff = await employeeProfileRepository.GetAllAsync();



            var leaveType = await leaveTypeRepository.GetAsync(leaveTypeId);

            var period = DateTime.Now.Year;
            List<LeaveAllocation> allocations = new List<LeaveAllocation>();


            //foreach(var employee in userEmployees)
            //{
            //    if (await AllocationExists(employee.Id, leaveTypeId, period))
            //        continue;
            //    var allocation = new LeaveAllocation
            //    {
            //        EmployeeId = employee.Id,
            //        LeaveTypeId = leaveTypeId,
            //        Period = period,
            //        DaysAllocated = leaveType.DefaultDays
            //    };

            //    allocations.Add(allocation);
            //    // method from the GenereicRepository
            //}





            foreach (var staff in allStaff)
            {
                // check if its an active staff
                if (staff.Status != 1)
                    continue;

                // check if the the staff has already been allocated leave
                if (await AllocationExists(staff.Id, leaveTypeId, period))
                    continue;

                var allocation = new LeaveAllocation
                {
                    EmployeeId = staff.Id,
                    LeaveTypeId = leaveTypeId,
                    Period = period,
                    DaysAllocated = leaveType.DefaultDays
                };
                    allocations.Add(allocation);
                employeeAllocated.Add(staff);

            }


            // method from the GenereicRepository
            await AddRangeAsync(allocations);

            foreach (var employee in employeeAllocated)
            {
                await emailSender.SendEmailAsync(employee.Email, $"Leave Allocation for {period}", $" You have been allocated {leaveType.Name} Leave for the period of {period}. You have been allocated {leaveType.DefaultDays} days.");
            }
        }

        public async Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model)
        {
            var leaveAllocation = await GetAsync(model.Id);
            if (leaveAllocation == null)
            {
                return false;
            }
            leaveAllocation.Period = model.Period;
            leaveAllocation.DaysAllocated = model.DaysAllocated;
            leaveAllocation.DaysUsed = model.DaysUsed;
            leaveAllocation.PublicHolidays = model.PublicHolidays;
            leaveAllocation.DaysBroughtForward = model.DaysBroughtForward;

            await UpdateAsync(leaveAllocation); // mapper.Map<LeaveAllocation>(leaveAllocation));
            return true;
        }

        public async Task<LeaveAllocation?> GetEmployeeAllocation(string employeeId, int leaveTypeId)
        {
            // if not found it will return null because of LeaveAllocation?
            //var leaveAllocation = context.LeaveAllocations.Include(q => q.LeaveType).Where(q => q.EmployeeId == employeeId && q.LeaveTypeId == leaveTypeId);
            var leaveAllocation = await context.LeaveAllocations.FirstOrDefaultAsync(q => q.EmployeeId == employeeId && q.LeaveTypeId == leaveTypeId);
            return leaveAllocation;
        }
    }
}
