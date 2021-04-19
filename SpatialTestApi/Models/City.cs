using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SpatialTestApi.Models
{
    [Table("Cities", Schema = "Application")]
    public class City
    {
        
        public int CityID { get; set; }


        public string CityName { get; set; }


    }
}
