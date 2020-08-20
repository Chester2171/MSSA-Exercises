using System;
using System.Collections.Generic;
using System.Text;

namespace KilometersToMiles
{
    class Conversion
    {
        public static double KilometersToMiles(double input)
        {
            input = input / 1.609;
            return Math.Round(input, 2);
        }
        public static double MilesToKilometers(double input)
        {
            input = input * 1.609;
            return Math.Round(input, 2);
        }
    }
}
