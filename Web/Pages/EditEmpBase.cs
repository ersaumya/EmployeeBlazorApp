using DomainModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;
using Web.Services;

namespace Web.Pages
{
    public class EditEmpBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Inject]
        public IDepartmentService DepartmentService { get; set; }

        public List<Department> Departments { get; set; } = new List<Department>();

        private Employee Employee { get; set; } = new Employee();
        public EditEmployeeModel EditEmployeeModel { get; set; } = new EditEmployeeModel();

        [Parameter]
        public string Id { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetEmployee(int.Parse(Id));
            Departments = (await DepartmentService.GetDepartments()).ToList();

            EditEmployeeModel.EmployeeId = Employee.EmployeeId;
            EditEmployeeModel.FirstName = Employee.FirstName;
            EditEmployeeModel.LastName = Employee.LastName;
            EditEmployeeModel.Email = Employee.Email;
            EditEmployeeModel.ConfirmEmail = Employee.Email;
            EditEmployeeModel.DoB = Employee.DoB;
            EditEmployeeModel.Gender = Employee.Gender;
            EditEmployeeModel.Photo = Employee.Photo;
            EditEmployeeModel.DepartmentId = Employee.DepartmentId;
            EditEmployeeModel.Department = Employee.Department;

        }

        protected void HandleValidSubmit()
        {

        }
    }
}
