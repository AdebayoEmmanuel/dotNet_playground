using System;

namespace _0x00_polygon
{
    class Program
    {
        static void Main()
        {
            messages msg = new();
            msg.display(0);

            regularPolygon polygon = new();
            msg.display(1);
            polygon.sides = Convert.ToUInt16(Console.ReadLine());

            int intAng = polygon.interiorAng();
            msg.display(2, intAng);
        }
    }
}
