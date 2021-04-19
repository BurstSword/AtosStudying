using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SpatialTestApi.Models
{
    [Table("Countries", Schema = "Application")]
    public class Country
    {
        public int CountryID { get; set; }

        public string CountryName { get; set; }

        // Database includes both Polygon and MultiPolygon values
        public Geometry Border { get; set; }
    }
}
