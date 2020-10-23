using PieShopFullProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopFullProject.Pages.Seed
{
    public partial class CountrySeed
    {
        public List<Country> Countries { get; set; }
        public string message { get; set; } = null;

        protected override void OnInitialized()
        {

            SeedCountries();
            message = "Seeding Complete";
        }

        private void SeedCountries()
        {
            Countries = new List<Country>()
            {
                new Country {CountryId = 1, Name = "Belgium"},
                new Country {CountryId = 2, Name = "Netherlands"},
                new Country {CountryId = 3, Name = "USA"},
                new Country {CountryId = 4, Name = "Japan"},
                new Country {CountryId = 5, Name = "China"},
                new Country {CountryId = 6, Name = "UK"},
                new Country {CountryId = 7, Name = "France"},
                new Country {CountryId = 8, Name = "Brazil"}


            };
            using (var _db = new ApplicationDbContext())
            {

                foreach (var country in Countries)
                {
                    _db.Countries.Add(country);
                    _db.SaveChanges();

                }
            }


        }
    }
}
