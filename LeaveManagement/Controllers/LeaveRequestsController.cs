using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaveManagement.Data;
using System.Collections;
using LeaveManagement.Models;
using LeaveManagement.Contracts;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Authorization;
using LeaveManagement.Constants;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace LeaveManagement.Controllers
{
    [Authorize]
    public class LeaveRequestsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILeaveRequestRepository leaveRequestRepository;
        private readonly IEmployeeProfileRepository employeeProfileRepository;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly UserManager<Employee> userManager;
        private readonly IMapper mapper;
        private readonly ILogger<LeaveRequestsController> _logger;

        public LeaveRequestsController(ApplicationDbContext context,
            ILeaveRequestRepository leaveRequestRepository,
            IEmployeeProfileRepository employeeProfileRepository,
            IHttpContextAccessor httpContextAccessor,
            UserManager<Employee> userManager,
            IMapper mapper,
            ILogger<LeaveRequestsController> logger
            )
        {
            _context = context;
            this.leaveRequestRepository = leaveRequestRepository;
            this.employeeProfileRepository = employeeProfileRepository;
            this.httpContextAccessor = httpContextAccessor;
            this.userManager = userManager;
            this.mapper = mapper;
            _logger = logger;
        }


        [Authorize(Roles = Roles.allApproval)]
        // GET: LeaveRequests
        public async Task<IActionResult> Index()
        {
            var model = await leaveRequestRepository.GetAdminLeaveRequestVM();

            return View(model);
        }




        // GET: LeaveRequests
        public async Task<IActionResult> MyLeave()
        {
            // null will return the logged in user while if a user id is passed it will return the user with that id
            var model = await leaveRequestRepository.GetMyLeaveDetails(null);
            return View(model);
        }








        // GET: LeaveRequests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var user = await userManager.GetUserAsync(httpContextAccessor?.HttpContext?.User);

            if (id == null)
            {
                return NotFound();
            }

            var leaveRequest = mapper.Map<LeaveRequestVM>(await _context.LeaveRequests
                .Include(l => l.LeaveType)
                .FirstOrDefaultAsync(m => m.Id == id)
                );

            if (leaveRequest == null)
            {
                return NotFound();
            }

            leaveRequest.Employee = await employeeProfileRepository.GetEmployeeProfile(leaveRequest.EmployeeId);
            leaveRequest.Reliever = await employeeProfileRepository.GetEmployeeProfile(leaveRequest.RelieverID);
            leaveRequest.HREmployee = await employeeProfileRepository.GetEmployeeProfile(leaveRequest.HREmployeeId);
            leaveRequest.SupervisorEmployee = await employeeProfileRepository.GetEmployeeProfile(leaveRequest.SupervisorEmployeeId);
            leaveRequest.GroupHeadEmployee = await employeeProfileRepository.GetEmployeeProfile(leaveRequest.GroupHeadEmployeeId);
            leaveRequest.MDEmployee = await employeeProfileRepository.GetEmployeeProfile(leaveRequest.MDEmployeeId);
            leaveRequest.EDEmployee = await employeeProfileRepository.GetEmployeeProfile(leaveRequest.EDEmployeeId);
           
            leaveRequest.LoggedInUser = mapper.Map<EmployeeProfile>(user);

            return View(leaveRequest);
        }

        // GET: LeaveRequests/Create
        public async Task<IActionResult> Create()
        {
            try
            {
                var hrUserList = await employeeProfileRepository.GetUsersInRole(Roles.HR);
                var EDUserList = await employeeProfileRepository.GetUsersInRole(Roles.ED);
                var MDUserList = await employeeProfileRepository.GetUsersInRole(Roles.MD);


                var model = new LeaveRequestCreateVM
                {
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    LeaveTypes = new SelectList(_context.LeaveTypes, "Id", "Name"),
                    Relievers = new SelectList(_context.Staff.Where(q => q.DepartmentID == "235f3413-2f18-426f-9f20-944aad3a4623").ToList(), "Id", "Email"),
                    Supervisors = new SelectList(await leaveRequestRepository.GetSupervisors(), "Id", "Email"),
                    GroupHeads = new SelectList(await leaveRequestRepository.GetGroupHead(), "Id", "Email"),
                    DateRequested = DateTime.Now,

                };
                model.HREmployeeId = hrUserList.Count > 0 ? hrUserList[0].Id : "";
                model.EDEmployeeId = EDUserList.Count > 0 ? EDUserList[0].Id : "";
                model.MDEmployeeId = MDUserList.Count > 0 ? MDUserList[0].Id : "";

                ViewData["LeaveTypeId"] = new SelectList(_context.LeaveTypes, "Id", "Name"); // list to display the name of the leave
                List<IEnumerable> list = new List<IEnumerable>();
                list.Add("Select Approval");
                list.Add("Approved");
                list.Add("Not Approved");
                ViewData["Approved"] = new SelectList(list);



                //var rel = await _context.Staff.AnyAsync(q => q.DepartmentID == "");

                //ViewData["Reliever"] =  new SelectList();

                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error Approving Leave Request");
                throw;
                
            }

           
        }

        // POST: LeaveRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveRequestCreateVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                   var isValidRequest = await leaveRequestRepository.CreateLeaveRequest(model);
                    if (isValidRequest)
                    {
                        return  RedirectToAction(nameof(MyLeave));
                    }
                    ModelState.AddModelError(string.Empty, "You Have exceeded your leave allocation"); 
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error Creating Leave Request");
                ModelState.AddModelError(string.Empty,"An Error has occured while trying to save leave request. Please try again");
            }
            
            model.LeaveTypes = new SelectList(_context.LeaveTypes, "Id", "Name", model.LeaveTypeId);


            model.Relievers = new SelectList(_context.Staff.Where(q => q.DepartmentID == "235f3413-2f18-426f-9f20-944aad3a4623").ToList(), "Id", "Email", model.RelieverID);
            model.Supervisors = new SelectList(await leaveRequestRepository.GetSupervisors(), "Id", "Email", model.SupervisorEmployeeId);
            model.GroupHeads = new SelectList(await leaveRequestRepository.GetGroupHead(), "Id", "Email", model.GroupHeadEmployeeId);
            model.DateRequested = DateTime.Now;
            return View(model);
        }

        // GET: LeaveRequests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
           

            var leaveRequest = await leaveRequestRepository.GetLeaveReqyestAsync(id); 
            if (leaveRequest == null)
            {
                return NotFound();
            }

            ViewData["LeaveTypeId"] = new SelectList(_context.LeaveTypes, "Id", "Id", leaveRequest.LeaveTypeId);

            var user = await userManager.GetUserAsync(httpContextAccessor?.HttpContext?.User);
            leaveRequest.LoggedInUser = mapper.Map<EmployeeProfile>(user);


            return View(leaveRequest);
        }

        // POST: LeaveRequests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LeaveRequestVM leaveRequest)
        {
            if (id != leaveRequest.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                   await leaveRequestRepository.ChangeLeaveRequestStatus(id, leaveRequest);
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    _logger.LogError(ex, "Error Approving Leave Request");
                    if (!LeaveRequestExists(leaveRequest.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                catch(Exception ex)
                {
                    _logger.LogError(ex, "Error Approving Leave Request");
                    throw;
                }


                return RedirectToAction(nameof(Index));
            }
            ViewData["LeaveTypeId"] = new SelectList(_context.LeaveTypes, "Id", "Id", leaveRequest.LeaveTypeId);
            var user = await userManager.GetUserAsync(httpContextAccessor?.HttpContext?.User);
            leaveRequest.LoggedInUser = mapper.Map<EmployeeProfile>(user);
            return View(leaveRequest);
        }

        // GET: LeaveRequests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaveRequest = await _context.LeaveRequests
                .Include(l => l.LeaveType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leaveRequest == null)
            {
                return NotFound();
            }

            return View(leaveRequest);
        }









        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CancelRequest(int leaveRequestId)
        {
            try
            {
                await leaveRequestRepository.CancelLeaveRequest(leaveRequestId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error Cancelling Leave Request");
                throw;
            }

            return RedirectToAction(nameof(MyLeave));
        }





        // POST: LeaveRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var leaveRequest = await _context.LeaveRequests.FindAsync(id);
                _context.LeaveRequests.Remove(leaveRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error Approving Leave Request");
                throw;
            }

            
        }

        private bool LeaveRequestExists(int id)
        {
            return _context.LeaveRequests.Any(e => e.Id == id);
        }
    }
}
