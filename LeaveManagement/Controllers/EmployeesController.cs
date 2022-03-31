using AutoMapper;
using LeaveManagement.Common.Constants;
using LeaveManagement.Application.Contracts;
using LeaveManagement.Data;
using LeaveManagement.Common.Models;
using LeaveManagement.Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Controllers
{
    public class EmployeesController : Controller
    {
        public UserManager<Employee> userManager;
        public IEmployeeProfileRepository employeeProfileRepository;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;
        private readonly IDepartmentRepository departmentRepository;
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IMapper mapper;

        public EmployeesController(UserManager<Employee> userManager,
                                        IEmployeeProfileRepository employeeProfileRepository,
                                        ILeaveAllocationRepository leaveAllocationRepository,
                                        IDepartmentRepository departmentRepository,
                                        ILeaveTypeRepository leaveTypeRepository,
                                        IMapper mapper)
        {
            this.userManager = userManager;
            this.employeeProfileRepository = employeeProfileRepository;
            this.leaveAllocationRepository = leaveAllocationRepository;
            this.departmentRepository = departmentRepository;
            this.leaveTypeRepository = leaveTypeRepository;
            this.mapper = mapper;
        }










        // GET: EmployeesController
        public async Task<ActionResult> GetSystemUsers()
        {
            var users = await userManager.GetUsersInRoleAsync(Roles.User);
            var supervisors = await userManager.GetUsersInRoleAsync(Roles.Supervisor);
            var Hr = await userManager.GetUsersInRoleAsync(Roles.HR);

            var userModel = mapper.Map<List<EmployeeVM>>(users);
            var supervisorModel = mapper.Map<List<EmployeeVM>>(supervisors);
            var HrModel = mapper.Map<List<EmployeeVM>>(Hr);

            UserByRoles viewModel = new UserByRoles();
            viewModel.Users = userModel;
            viewModel.Supervisors = supervisorModel;
            viewModel.HR = HrModel;

            return View(viewModel);
        }



        public async Task<ActionResult> GetEmployees()
        {
            var employees = await employeeProfileRepository.GetAllAsync();
            foreach(var employee in employees)
            {
                // get the deparment description
                employee.DepartmentID = await departmentRepository.GetDepartmentName(employee.DepartmentID);
            }
            var employeesViewModel = mapper.Map<List<EmployeeProfileVM>>(employees);
            

            return View(employeesViewModel);
        }

        public async Task<ActionResult> Details(string id)
        {
            var employee = await employeeProfileRepository.GetEmployeeProfile(id);
          if(employee == null)
            {
                return NotFound();
            }
                // get the deparment description
           employee.DepartmentID = await departmentRepository.GetDepartmentName(employee.DepartmentID);
            
            return View(employee);
        }




        // GET: EmployeesController/Delete/5
        public async Task<ActionResult> Edit(string id)
        {
            var user =  await employeeProfileRepository.GetEmployeeProfile(id);

            if(user == null)
            {
            
                return NotFound();
            }

            return View(user);
        }



        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, EmployeeProfileVM modelVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var model = mapper.Map<EmployeeProfile>(modelVM);
                    await employeeProfileRepository.UpdateAsync(model);
                    
                        return RedirectToAction(nameof(Details), new { id = modelVM.Id });
                    
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An Error Has Occured. Please Try Again Later");
            }
           // modelVM.Employee = mapper.Map<EmployeeProfileVM>(await employeeProfileRepository.GetEmployeeProfile(model.EmployeeId));
           // modelVM.LeaveType = mapper.Map<LeaveTypeVM>(await leaveTypeRepository.GetAsync(model.LeaveTypeId));
            return View(modelVM);
        }






        public async Task<ActionResult> GetDepartments()
        {
            var departments = await departmentRepository.GetAllAsync();
            foreach (var dept in departments)
            {
                // get the deparment description
                var hod = await employeeProfileRepository.GetEmployeeProfile(dept.HOD);
                if(hod != null)
                {
                    dept.HOD = hod?.Lastname + " " + hod?.Firstname;
                }
                
            }
            var deptVM = mapper.Map<List<DepartmentVM>>(departments);


            return View(deptVM);
        }




        // GET: EmployeesController/ViewAllocation/5
        public async Task<ActionResult> ViewAllocation(string id)
        {
            var leaveAllocation = await leaveAllocationRepository.GetEmployeeAllocations(id);

            return View(leaveAllocation);
        }








        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // Edit Leave Allocation
        // GET: EmployeesController/EditAllocation/5
        public async Task<ActionResult> EditAllocation(int id)
        {
            var leaveAllocation = await leaveAllocationRepository.GetEmployeeAllocation(id);
            if(leaveAllocation == null)
            {
                return NotFound();
            }
            return View(leaveAllocation);
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAllocation(int id, LeaveAllocationEditVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (await leaveAllocationRepository.UpdateEmployeeAllocation(model))
                    {
                        return RedirectToAction(nameof(ViewAllocation), new { id = model.EmployeeId });
                    }
                }
            }
            catch(Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An Error Has Occured. Please Try Again Later");
            }
            model.Employee = mapper.Map<EmployeeProfileVM>(await employeeProfileRepository.GetEmployeeProfile(model.EmployeeId));
            model.LeaveType = mapper.Map<LeaveTypeVM>(await leaveTypeRepository.GetAsync(model.LeaveTypeId));
            return View(model);
        }

        //// GET: EmployeesController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: EmployeesController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
