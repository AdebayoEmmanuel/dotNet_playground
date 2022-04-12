using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0x00_polygon
{
    class messages
    {
        const string welcomeMsg = "Welcome to the Polygon App";
        const string inputPrompt = "Please enter number of sides: ";
        const string solutionMsg = "Sum of the interior angle of this Polygon is: {0}";
        public void display(int msgIndex, int? intAng = null)
        {
            switch (msgIndex)
            {
                case 0:
                    Console.WriteLine(welcomeMsg);
                    break;
                case 1:
                    Console.WriteLine(inputPrompt);
                    break;
                case 2:
                    Console.WriteLine(solutionMsg, intAng);
                    break;

            }
        }
    }
}
