using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCrud.Models
{
    [Table("emp", Schema="public")]
    public class Emp
    {
        [Key]
        public int empid { get; set; }
        public string empname  { get; set; }
        public string dni { get; set; }
        public int age { get; set; }
    }
}
