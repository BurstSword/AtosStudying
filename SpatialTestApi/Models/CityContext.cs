using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpatialTestApi.Models
{
    public class CityContext :DbContext
    {
        public CityContext(DbContextOptions<CityContext> options) 
            : base(options) {}

        public DbSet<City> Cities { get; set; }
    }
}
