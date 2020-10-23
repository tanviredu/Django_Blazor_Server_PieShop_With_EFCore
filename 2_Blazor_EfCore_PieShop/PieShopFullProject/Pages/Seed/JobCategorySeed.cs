using PieShopFullProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopFullProject.Pages.Seed
{
    public partial class JobCategorySeed
    {
        public List<JobCategory> JobCategories { get; set; }
        public string message = null;
        protected override void OnInitialized()
        {

            SeedjobCategories();
            message = "Seeding Complete";
        }

        private void SeedjobCategories()
        {
            JobCategories = new List<JobCategory>()
            {
                new JobCategory{JobCategoryId = 1, JobCategoryName = "Pie research"},
                new JobCategory{JobCategoryId = 2, JobCategoryName = "Sales"},
                new JobCategory{JobCategoryId = 3, JobCategoryName = "Management"},
                new JobCategory{JobCategoryId = 4, JobCategoryName = "Store staff"},
                new JobCategory{JobCategoryId = 5, JobCategoryName = "Finance"},
                new JobCategory{JobCategoryId = 6, JobCategoryName = "QA"},
                new JobCategory{JobCategoryId = 7, JobCategoryName = "IT"},
                new JobCategory{JobCategoryId = 8, JobCategoryName = "Cleaning"},
                new JobCategory{JobCategoryId = 9, JobCategoryName = "Bakery"},
                new JobCategory{JobCategoryId = 9, JobCategoryName = "Bakery"}

            };

            using (var _context = new ApplicationDbContext())
            {
                foreach (var job in JobCategories)
                {
                    _context.JobCategories.Add(job);
                    _context.SaveChanges();

                }
            }

        }
    }
    
}
