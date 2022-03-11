using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaveManagement.Data;
using AutoMapper;
using LeaveManagement.Models;
using LeaveManagement.Contracts;
using Microsoft.AspNetCore.Authorization;
using LeaveManagement.Constants;

namespace LeaveManagement.Controllers
{



    [Authorize] // Will allow only loged in   admin and HR users to access this module
    public class LeaveTypesController : Controller
    {

        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IMapper _mapper;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;
        const string admin_And_HR = Roles.Administrator + "," + Roles.HR;


        public LeaveTypesController(ILeaveTypeRepository leaveTypeRepository, IMapper mapper, ILeaveAllocationRepository leaveAllocationRepository)
        {
            this.leaveTypeRepository = leaveTypeRepository;
            this._mapper = mapper;
            this.leaveAllocationRepository = leaveAllocationRepository;
        }






        // GET: LeaveTypes
        public async Task<IActionResult> Index()
        {

            var leaveTypes = _mapper.Map<List<LeaveTypeVM>>(await leaveTypeRepository.GetAllAsync());
            return View(leaveTypes);
        }



        // GET: LeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            var leaveType = await leaveTypeRepository.GetAsync(id);

            if (leaveType == null)
            {
                return NotFound();
            }
            var leaveTypeVM = _mapper.Map<LeaveTypeVM>(leaveType);
            return View(leaveTypeVM);
        }


        [Authorize(Roles = admin_And_HR)]
        // GET: LeaveTypes/Create
        public IActionResult Create()
        {
            return View();
        }





        // POST: LeaveTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = admin_And_HR)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveTypeVM leaveTypeVM)
        {
            if (ModelState.IsValid)
            {
                var leaveType = _mapper.Map<LeaveType>(leaveTypeVM);
                await leaveTypeRepository.AddAsync(leaveType);


                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }





        [Authorize(Roles = admin_And_HR)]
        // GET: LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {


            var leaveType = await leaveTypeRepository.GetAsync(id);
            if (leaveType == null)
            {
                return NotFound();
            }

            var leaveTypeVM = _mapper.Map<LeaveTypeVM>(leaveType);
            return View(leaveTypeVM);
        }








        // POST: LeaveTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = admin_And_HR)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LeaveType leaveTypeVM)
        {
            if (id != leaveTypeVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                try
                {
                    var leaveType = _mapper.Map<LeaveType>(leaveTypeVM);
                    await leaveTypeRepository.UpdateAsync(leaveType);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await LeaveTypeExists(leaveTypeVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }

        //// GET: LeaveTypes/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var leaveType = await _context.LeaveTypes
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (leaveType == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(leaveType);
        //}










        // POST: LeaveTypes/Delete/5
        [Authorize(Roles = Roles.Administrator)]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await leaveTypeRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> LeaveTypeExists(int id)
        {
            return await leaveTypeRepository.Exists(id);
        }










        // leave allocation method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AllocateLeave(int id)
        {
            await leaveAllocationRepository.LeaveAllocation(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
