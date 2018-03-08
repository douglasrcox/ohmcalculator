using System;
using OhmCalc.Classes;

namespace OhmCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var ohmCalculator = new OhmValueCalculator();

            string bandAColor = args.Length > 0 ? args[0] : string.Empty;
            string bandBColor = args.Length > 1 ? args[1] : string.Empty;
            string bandCColor = args.Length > 2 ? args[2] : string.Empty;
            string bandDColor = args.Length > 3 ? args[3] : string.Empty;
            
            Console.WriteLine("Ohm Calculation - Upper Band Only");
            Console.WriteLine("Upper band: " + ohmCalculator.CalculateOhmValue(bandAColor, bandBColor, bandCColor, bandDColor));

            // Pause
            Console.ReadKey();
        }
    }
}
