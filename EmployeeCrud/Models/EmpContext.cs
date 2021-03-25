using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCrud.Models
{
    public class EmpContext:DbContext
    {
        //Constructor to make DBContext
        public EmpContext(DbContextOptions<EmpContext> options)
            : base(options)
        {
        }
        //Configuring the connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                => optionsBuilder.UseNpgsql("Host=localhost;Database=employees;Username=postgres;Password=admin");
      
        //The item we need to make the CRUD
        public DbSet<Emp> EmpList { get; set; }
    }
}
