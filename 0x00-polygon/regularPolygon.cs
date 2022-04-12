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

        public int interiorAng()
        {
            int interiorAngle = (sides - 2) * 180;
            return interiorAngle;
        }
    }
}
