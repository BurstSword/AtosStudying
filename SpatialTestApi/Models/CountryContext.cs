using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpatialTestApi.Models
{
    public class CountryContext:DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options)
           : base(options) {
           }

        public DbSet<Country> Countries { get; set; }
    }
}
