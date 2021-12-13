using System;
using System.Globalization;

namespace Constructors {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("enter with product data:");
            Console.Write("name: ");
            string name = Console.ReadLine();
            Console.Write("price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Product p = new Product(name, price);

            // alternative sintax to initiate values
            Product p2 = new Product {
                Name = "Xbox",
                Price = 1200.0,
                Quantity = 1,
            };

            Console.WriteLine();
            Console.WriteLine("product data: " + p);

            Console.WriteLine();
            Console.Write("enter the number of products to be added in stock: ");
            int qtt = int.Parse(Console.ReadLine());
            p.AddProducts(qtt);
            Console.WriteLine();
            Console.WriteLine("updated data: " + p);

            Console.WriteLine();
            Console.Write("enter the number of products to be removed in stock: ");
            qtt = int.Parse(Console.ReadLine());
            p.RemoveProductcs(qtt);
            Console.WriteLine();
            Console.WriteLine("updated data: " + p);

            // printing alternative sintax
            Console.WriteLine("product 2: " 
                + p2.Name 
                + ", $" 
                + p2.Price  
                + ", " 
                +  p2.Quantity 
                + " unit.");
        }
    }
}