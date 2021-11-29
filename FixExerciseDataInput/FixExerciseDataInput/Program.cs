using System;
using System.Globalization;

namespace FixExerciseDataInput {
    internal class Program {
        static void Main(string[] args) {

            // fixation exercise

            Console.WriteLine("enter with your complete name:");
            string name = Console.ReadLine();
            Console.WriteLine("how many rooms has in your house:");
            int rooms = int.Parse(Console.ReadLine());
            Console.WriteLine("enter with the price of this product:");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("enter with your last name, years old and height (same line)");
            
            // split
            string[] vet = Console.ReadLine().Split(' ');
            string lastName = vet[0];
            int age = int.Parse(vet[1]);
            double height = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(name);
            Console.WriteLine(rooms);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("------------");
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
