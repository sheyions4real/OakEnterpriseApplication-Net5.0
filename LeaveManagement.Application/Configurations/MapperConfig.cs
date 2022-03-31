using AutoMapper;
using LeaveManagement.Data;
using LeaveManagement.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Application.Configurations
{
    public class MapperConfig :Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();
            CreateMap<EmployeeProfile, EmployeeProfileVM>().ReverseMap();
            CreateMap<EmployeeProfile, EmployeeAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationEditVM>().ReverseMap();
            CreateMap<Employee, EmployeeProfile>().ReverseMap();
            CreateMap<LeaveRequestCreateVM, LeaveRequest>().ReverseMap();
            CreateMap<LeaveRequestVM, LeaveRequest>().ReverseMap();
            CreateMap<EmployeeProfileVM, EmployeeProfile>().ReverseMap();
            CreateMap<Employee, EmployeeProfileVM>().ReverseMap();
            CreateMap<Department, DepartmentVM>().ReverseMap();

        }
    }
}
