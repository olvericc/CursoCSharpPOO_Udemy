using System;
using System.Globalization;

namespace ExampleProblem2 {
    internal class Program {
        static void Main(string[] args) {

            // instantiation
            Product p = new Product();

            Console.WriteLine("enter with product data");
            Console.Write("name: ");
            p.Name = Console.ReadLine();
            Console.Write("price: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("quantity in stock: ");
            p.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("product data: " + p);

        }
    }
}
