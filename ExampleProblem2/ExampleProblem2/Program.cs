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

            Console.WriteLine();
            Console.WriteLine("product data: " + p);

            Console.WriteLine();
            Console.Write("enter with the number of products to be added on stock: ");
            int addQuantity = int.Parse(Console.ReadLine());
            p.AddProducts(addQuantity);

            Console.WriteLine();
            Console.WriteLine("updated data: " + p);

            Console.WriteLine();
            Console.Write("enter with the numbers of products to be removed on stock: ");
            int removeQuantity = int.Parse(Console.ReadLine());
            p.RemoveProducts(removeQuantity);

            Console.WriteLine();
            Console.WriteLine("updated data: " + p);

        }
    }
}
