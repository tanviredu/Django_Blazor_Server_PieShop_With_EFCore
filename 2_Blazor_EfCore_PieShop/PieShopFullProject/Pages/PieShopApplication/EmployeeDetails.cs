using Microsoft.AspNetCore.Components;
using PieShopFullProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopFullProject.Pages.PieShopApplication
{
    public partial class EmployeeDetails
    {
        [Parameter]
        public string EmployeeId { get; set; }

        public Employee Employee { get; set; } = new Employee();
        public IEnumerable<Employee> Employees { get; set; }
        protected override void OnInitialized()
        {
            var _db = new ApplicationDbContext();
            Employees = _db.Employees.Select(x => x).ToList();
            Employee = Employees.FirstOrDefault(e => e.EmployeeId == int.Parse(EmployeeId));

        }
    }
}
