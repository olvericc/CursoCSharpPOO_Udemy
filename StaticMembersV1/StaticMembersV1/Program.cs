using System;
using System.Globalization;

namespace StaticMembersV1 {
    internal class Program {

        // const Pi
        static double Pi = 3.14;

        static void Main(string[] args) {

            Console.Write("enter with radius value: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            // instatiation
            double circ = Circuference(radius);
            double vol = Volume(radius);

            // printing 
            Console.WriteLine("circuference: " + circ.ToString("F2",
                CultureInfo.InvariantCulture));

            Console.WriteLine("volume: " + vol.ToString("F2",
                CultureInfo.InvariantCulture));

            Console.WriteLine("Pi value: " + Pi.ToString("F2", 
                CultureInfo.InvariantCulture));
        }

        // function to calculate Circuference

        static double Circuference(double r) {
            return 2.0 * Pi * r;    
        }

        // function to calculate Volume

        static double Volume(double r) {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}
