using EmployeeWebAPI.Models.Repositories;
using EmployeeWebAPI.Models;
using MesClasses;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeWebApi.Models.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _appDbContext;

        public DepartmentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Department GetDepartment(int departmentId)
        {
            return _appDbContext.Departments.FirstOrDefault(d => d.DepartmentId == departmentId);
        }

        public IEnumerable<Department> GetDepartments()
        {
            return _appDbContext.Departments;
        }
    }
}