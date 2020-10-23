using PieShopFullProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopFullProject.Pages.PieShopApplication
{
    public partial class EmployeeOverview
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override void OnInitialized()
        {
            var _db = new ApplicationDbContext();
            Employees = _db.Employees.Select(x => x).ToList();
        }
    }

    
}
