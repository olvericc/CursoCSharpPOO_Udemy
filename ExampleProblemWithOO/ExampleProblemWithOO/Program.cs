using System;
using System.Globalization;

namespace ExampleProblemWithOO {
    internal class Program {
        static void Main(string[] args) {

            Triangle x, y;
            
            // instantiation

            x = new Triangle();
            y = new Triangle();
            
            Console.WriteLine("enter with the measure of triangle x: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("enter with the measure of triangle x: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("area triangle x: " + areaX.ToString("F4", 
                CultureInfo.InvariantCulture));
            Console.WriteLine("area triangle y: " + areaY.ToString("F4",
                CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("greater area: X");
            }
            else if (areaX == areaY){
                Console.WriteLine("area with equal value");
            } 
            else {
                Console.WriteLine("greater area: Y");
            }
        }
    }
}
