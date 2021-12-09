using System;
using System.Globalization;

namespace StaticMembersV3 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("enter with radius value: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculator.Circuference(radius);
            double vol = Calculator.Volume(radius);

            Console.WriteLine("circuference: " + circ.ToString("F2",
                CultureInfo.InvariantCulture));
            Console.WriteLine("volume: " + vol.ToString("F2",
                CultureInfo.InvariantCulture));
            Console.WriteLine("pi value: " + Calculator.Pi.ToString("F2",
                CultureInfo.InvariantCulture));
        }
    }
}
