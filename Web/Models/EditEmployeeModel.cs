using DomainModels;
using DomainModels.CustomValidators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class EditEmployeeModel
    {
        public int EmployeeId { get; set; }

        [Required]
        [MinLength(3)]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [EmailAddress]
        [EmailDomainValidator(AllowedDomain = "soum.com", ErrorMessage = "soum.com is allowed only")]
        public string Email { get; set; }

        [CompareProperty("Email",ErrorMessage ="Email and Confirm Email must match")]
        public string ConfirmEmail { get; set; }
        public DateTime DoB { get; set; }
        public Gender Gender { get; set; }
        [Required]
        public int? DepartmentId { get; set; }
        public string Photo { get; set; }
        [ValidateComplexType]
        public Department Department { get; set; } = new Department();
    }
}
