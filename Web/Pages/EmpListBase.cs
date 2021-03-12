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
    }
}
