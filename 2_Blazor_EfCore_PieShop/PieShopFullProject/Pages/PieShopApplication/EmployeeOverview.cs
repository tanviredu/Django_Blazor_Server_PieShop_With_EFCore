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
        public Employee Employee { get; set; }

        protected override void OnInitialized()
        {
            var _db = new ApplicationDbContext();
            Employees = _db.Employees.Select(x => x).ToList();
        }

        void Delete(int id) {
            using (var _db = new ApplicationDbContext()) {
                Employee = _db.Employees.FirstOrDefault(e => e.EmployeeId == id);
                _db.Employees.Remove(Employee);
                _db.SaveChanges();

                // regresh the page
                OnInitialized();


            }   
        }
    }

    
}
