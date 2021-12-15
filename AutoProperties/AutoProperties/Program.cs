using System;
using System.Globalization;

namespace Constructors {
    internal class Program {
        static void Main(string[] args) {

            Product p = new Product("tv", 500.0, 10);

            p.Name = "TV 4K";

            Console.WriteLine(p.Name);
            Console.WriteLine(p.Price);

        }
    }
}
