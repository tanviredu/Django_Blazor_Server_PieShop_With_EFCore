using Microsoft.AspNetCore.Components;
using PieShopFullProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopFullProject.Pages.PieShopApplication
{
    public partial class AddEmployee
    {
        [Inject]
        public NavigationManager navigation { get; set; }
        public Employee Employee = new Employee();
        public string CountryId = string.Empty;
        public string JobCategoryId = string.Empty;
        public List<Country> Countries { get; set; } = new List<Country>();
        public List<JobCategory> JobCategories { get; set; } = new List<JobCategory>();
        protected override void OnInitialized()
        {
            var _db = new ApplicationDbContext();
            Countries = _db.Countries.Select(x => x).ToList();
            JobCategories = _db.JobCategories.Select(x => x).ToList();
        

        }

        public void Add() {
            Employee.CountryId = int.Parse(CountryId);
            Employee.JobCategoryId = int.Parse(JobCategoryId);
            using (var _context = new ApplicationDbContext()) {
                _context.Employees.Add(Employee);
                int row_affected = _context.SaveChanges();
                if (row_affected > 0) {
                    var Employee = new Employee();
                    navigation.NavigateTo("/employeeoverview");
                }
                
            }
        
        
        }

    }

    

}
