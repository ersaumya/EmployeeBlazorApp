using DomainModels.CustomValidators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DomainModels
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        [MinLength(3)]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [EmailAddress]
        [EmailDomainValidator(AllowedDomain ="soum.com",ErrorMessage ="soum.com is allowed only")]
        public string Email { get; set; }
        public DateTime DoB { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public string Photo { get; set; }
        
        public Department Department { get; set; }
    }
}
