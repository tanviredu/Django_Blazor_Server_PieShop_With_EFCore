using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PieShopFullProject.Models
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<Employee> Employees { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseSqlite("Data Source=database.db");
            
            // package manager console setup
            // add-migration initial
            // update-database
        }

    }
}
