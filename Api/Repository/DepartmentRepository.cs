using Api.Data;
using DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _appDbContext;
        public DepartmentRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }


        public Department GetDepartment(int departmentId)
        {
            return _appDbContext.Departments
                 .FirstOrDefault(d => d.DepartmentId == departmentId);
        }

        public IEnumerable<Department> GetDepartments()
        {
            return _appDbContext.Departments;
        }
    }
}
