using AutoMapper;
using LeaveManagement.Contracts;
using LeaveManagement.Data;
using LeaveManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IEmployeeProfileRepository employeeProfileRepository;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly UserManager<Employee> userManager;
        private readonly IMapper mapper;
        private readonly ILogger<HomeController> _logger;


        public HomeController(ApplicationDbContext context,
            IEmployeeProfileRepository employeeProfileRepository,
            IHttpContextAccessor httpContextAccessor,
            UserManager<Employee> userManager,
            IMapper mapper,
            ILogger<HomeController> logger)
        {
            this.context = context;
            this.employeeProfileRepository = employeeProfileRepository;
            this.httpContextAccessor = httpContextAccessor;
            this.userManager = userManager;
            this.mapper = mapper;
            _logger = logger;
        }

        [Authorize]
        public async Task<IActionResult> IndexAsync()
        {

            // testing the logger

           // throw new Exception("testing the exception logging.");


            //Get User that is logged in
            var user = await userManager.GetUserAsync(httpContextAccessor?.HttpContext?.User); 
            // get all leave requests inner join leavetype
            var leaveRequests = await context.LeaveRequests.Include(q => q.LeaveType).Where(q => q.EmployeeId == user.Id).ToListAsync();
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

            return View(model);
        }

          // this will restrict un authorized user to access this controller
        public IActionResult Privacy()
        {
            return View();
        }




        /// <summary>
        //To display error to the users when error occurred
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {

            // to handle an exception that was not handled in a try catch block
            var requestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            if(exceptionHandlerPathFeature != null)
            {
                Exception exception = exceptionHandlerPathFeature.Error;
                _logger.LogError(exception, $"Error Encountered By User: {this.User?.Identity?.Name} | Request Id: {requestId}");

            }


            return View(new ErrorViewModel { RequestId = requestId});
        }
    }
}
