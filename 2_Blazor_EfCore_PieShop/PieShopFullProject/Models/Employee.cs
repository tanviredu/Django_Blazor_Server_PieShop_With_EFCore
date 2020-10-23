using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace PieShopFullProject.Models
{
    public class Employee
    {
        
        public int EmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        
        public DateTime BirthDate { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Street { get; set; }
        public string zip { get; set; }
        public bool Smoker { get; set; }
        public string PhoneNumber { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public Gender Gender { get; set; }

        // one to one relationship
        public int CountryId { get; set; }
        public Country Country { get; set; }

        //one to one relationship
        public int JobCategoryId { get; set; }
        public JobCategory JobCategory { get; set; }


        public string Comment { get; set; }
        public DateTime? JoinedDate { get; set; }
        public DateTime? ExitDate { get; set; }



    }
}
