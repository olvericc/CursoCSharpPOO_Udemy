using System;
using System.Globalization;

namespace StaticMembersV2 {
    internal class Program {
        static void Main(string[] args) {
            
            // instantiation 
            Calculator calc = new Calculator();

            Console.Write("enter with radius value: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circuference(radius);
            double vol = calc.Volume(radius);

            Console.WriteLine("circuference: " + circ.ToString("F2",
                CultureInfo.InvariantCulture));
            Console.WriteLine("volume: " + vol.ToString("F2",
                CultureInfo.InvariantCulture));
            Console.WriteLine("pi value: " + calc.Pi.ToString("F2",
                CultureInfo.InvariantCulture));
        }
    }
}
