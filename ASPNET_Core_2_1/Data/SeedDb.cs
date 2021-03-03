using PrestoStore.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_Core_2_1.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
        }

        private async Task CheckCountriesAsync()
        {
            if (!_context.Countries.Any())
            {
                _context.Countries.Add(new Country
                {
                    Name = "Venezuela",
                    Departments = new List<Department>
                {
                    new Department
                    {
                        Name = "Zulia",
                        Cities = new List<City>
                        {
                            new City { Name = "Maracaibo" },
                            new City { Name = "San Francisco" },
                            new City { Name = "Cabimas" }
                        }
                    },
                    new Department
                    {
                        Name = "Caracas",
                        Cities = new List<City>
                        {
                            new City { Name = "Ciudad Capital" }
                        }
                    },
                    new Department
                    {
                        Name = "Tachira",
                        Cities = new List<City>
                        {
                            new City { Name = "San Cristobal" },
                            new City { Name = "Colon" },
                            new City { Name = "San Antonio" }
                        }
                    }
                }
                });
                _context.Countries.Add(new Country
                {
                    Name = "USA",
                    Departments = new List<Department>
                {
                    new Department
                    {
                        Name = "California",
                        Cities = new List<City>
                        {
                            new City { Name = "Los Angeles" },
                            new City { Name = "San Diego" },                        
                        }
                    },
                    new Department
                    {
                        Name = "Illinois",
                        Cities = new List<City>
                        {
                            new City { Name = "Chicago" },
                            new City { Name = "Springfield" }
                        }
                    }
                }
                });
                await _context.SaveChangesAsync();
            }
        }
    }

}
