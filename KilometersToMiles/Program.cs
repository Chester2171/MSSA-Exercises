using System;

namespace KilometersToMiles
{
    class Program
    {
        static double Distance()
        {
            double input = 0;
            Console.WriteLine("Enter a distance to see it in both Kilometers and Miles: ");
            try
            {
                input = double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Distance();
            }
            return input;
        }
        
        static void Main(string[] args)
        {
            double input = Distance();
            Console.WriteLine($"{input} Kilometers converted to Miles is {Conversion.KilometersToMiles(input)}");
            Console.WriteLine($"{input} Miles converted to Kilometers is {Conversion.MilesToKilometers(input)}");
        }
    }
}
