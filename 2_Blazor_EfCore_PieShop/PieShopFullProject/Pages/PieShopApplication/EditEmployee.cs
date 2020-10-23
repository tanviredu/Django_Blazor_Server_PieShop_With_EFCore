using Microsoft.AspNetCore.Components;
using PieShopFullProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopFullProject.Pages.PieShopApplication
{
    public partial  class EditEmployee
    {
        [Parameter]
        public string EmployeeId { get; set; }
        [Inject]
        public NavigationManager navigation { get; set; }
        public Employee Employee { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        public string CountryId = string.Empty;
        public string JobCategoryId = string.Empty;
        public List<Country> Countries { get; set; } = new List<Country>();
        public List<JobCategory> JobCategories { get; set; } = new List<JobCategory>();
        protected override void OnInitialized()
        {
            
            var _db = new ApplicationDbContext();
            Employees = _db.Employees.Select(x => x).ToList();
            Employee = Employees.FirstOrDefault(e => e.EmployeeId == int.Parse(EmployeeId));
            Countries = _db.Countries.Select(x => x).ToList();
            JobCategories = _db.JobCategories.Select(x => x).ToList();


        }

        public void Edit()
        {

            Employee.CountryId = int.Parse(CountryId);
            Employee.JobCategoryId = int.Parse(JobCategoryId);
            using (var _context = new ApplicationDbContext())
            {
                _context.Employees.Update(Employee);
                int row_affected = _context.SaveChanges();
                if (row_affected > 0)
                {
                    var Employee = new Employee();
                    navigation.NavigateTo("/employeeoverview");
                }

            }


        }
    }
}
