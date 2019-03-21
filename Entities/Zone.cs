using System;
using GeoJSON.Net.Feature;
using GeoJSON.Net.Geometry;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Zone
    {
        public int Id { get; set; }

        public Polygon PolyZone { get; set; }

          //todo add geometry / polygone
    }
}
