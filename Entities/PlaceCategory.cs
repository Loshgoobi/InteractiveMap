using System;
using GeoJSON.Net.Feature;
using GeoJSON.Net.Geometry;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public class PlaceCategory
    {
        public int Id { get; set; }

        //todo add posi
        public Position PlaceCategoryPosition { get; set; }
    }


}
