using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0x00_polygon
{
    class regularPolygon
    {
        //Attributes of a regular polygon
        public int length, sides;

        public void interiorAng()
        {
            double interiorAngle = (sides - 2) * 180;
            Console.WriteLine("Sum of the interior angle of this Polygon is: {0}", interiorAngle);
        }
    }
}
