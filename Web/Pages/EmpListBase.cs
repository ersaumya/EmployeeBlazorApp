using DomainModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Pages
{
    public class EmpListBase:ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployee);
        }

        private void LoadEmployee()
        {
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "Soumya",
                LastName = "Rout",
                Email = "ersaumyarout@gmail.com",
                DoB = new DateTime(1990, 10, 2),
                Gender = Gender.Male,
                DeptId = 1,
                Photo = "images/pic1.jpg"
            };
            Employee e2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Maha",
                LastName = "Rout",
                Email = "mahat@gmail.com",
                DoB = new DateTime(1997, 10, 5),
                Gender = Gender.Male,
                DeptId = 2,
                Photo = "images/pic2.jpg"
            };
            Employees = new List<Employee> { e1, e2 };
        }
    }
}
