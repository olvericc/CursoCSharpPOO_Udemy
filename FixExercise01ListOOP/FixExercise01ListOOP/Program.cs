using System;
using System.Globalization;

namespace FixExercise01ListOOP {
    internal class Program {
        static void Main(string[] args) {

            // fixation exercise 01

            // instantiation
            Retangle r = new Retangle();

            Console.WriteLine("enter with width and height of retangle");
            r.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("area: " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("perimeter: " + r.Perimeter().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("diagonal: " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
