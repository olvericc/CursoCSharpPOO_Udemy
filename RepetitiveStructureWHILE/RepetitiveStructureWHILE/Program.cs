using System;
using System.Globalization;

namespace RepetitiveStructureWHILE {
    internal class Program {
        static void Main(string[] args) {
            
            Console.Write("enter with one number: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0) { 
                double root = Math.Sqrt(x);
                Console.WriteLine("square root: " + root.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("enter another number: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("negative number!");
        }
    }
}
