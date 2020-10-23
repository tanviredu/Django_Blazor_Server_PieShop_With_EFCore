using PieShopFullProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopFullProject.Pages.Seed
{
    public partial class EmployeeSeed { 
         public IEnumerable<Employee> Employees { get; set; }
         public string message = null;

        protected override void OnInitialized()
        {

            SeedEmployees();
            message = "Seeding Complete";
        }
        private void SeedEmployees()
        {

            var e1 = new Employee
            {
                CountryId = 1,
                MaritalStatus = MaritalStatus.Single,
                BirthDate = new DateTime(1989, 3, 11),
                Email = "bethany@bethanyspieshop.com",
                EmployeeId = 1,
                FirstName = "Bethany",
                LastName = "Smith",
                Gender = Gender.Female,
                PhoneNumber = "324777888773",
                Smoker = false,
                Street = "Grote Markt 1",
                JobCategoryId = 1,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2015, 3, 1)
            };

            var e2 = new Employee
            {
                CountryId = 2,
                MaritalStatus = MaritalStatus.Married,
                BirthDate = new DateTime(1979, 1, 16),
                Email = "gill@bethanyspieshop.com",
                EmployeeId = 2,
                FirstName = "Gill",
                LastName = "Cleeren",
                Gender = Gender.Female,
                PhoneNumber = "33999909923",
                Smoker = false,
                Street = "New Street",
                JobCategoryId = 1,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2017, 12, 24)
            };

            Employees = new List<Employee> { e1, e2 };

            
                foreach (var employe in Employees)
                {
                    using (var _db = new ApplicationDbContext())
                        {

                        _db.Employees.Add(employe);
                        _db.SaveChanges();
                        // after seeding probably gives an error
                        // but ignore for this
                        // because our job is done
                       }
                }


        }


    }
}
