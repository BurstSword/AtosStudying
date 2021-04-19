using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using NetTopologySuite;
using NetTopologySuite.Geometries;
using SpatialTestApi.Models;

namespace SpatialTestApi.Mapper
{
    public class MyMapper :Profile
    {
        public MyMapper()
        {
            CreateMap<City, CityDTO>().ForMember(x => x.Latitude, x => x.MapFrom(y => y.Location.Y))
                .ForMember(x => x.Longitude, x => x.MapFrom(y => y.Location.X));

            var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);

            CreateMap<CityDTO, City>().ForMember(x => x.Location,
                x => x.MapFrom(y => geometryFactory.CreatePoint(new Coordinate(y.Longitude, y.Latitude))));

        }
    }
}
