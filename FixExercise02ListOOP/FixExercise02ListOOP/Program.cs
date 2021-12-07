using System;
using System.Globalization;

namespace FixExercise02ListOOP {
    internal class Program {
        static void Main(string[] args) {
            
            // fixation exercise 02

            // instantiation
            Employee emp1 = new Employee();

            Console.Write("name: ");
            emp1.Name = Console.ReadLine();
            Console.Write("gross salary: ");
            emp1.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("tax: ");
            emp1.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("employee: " + emp1);

            Console.WriteLine();
            Console.Write("enter the percentage to increase the salary: ");
            double p = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            emp1.IncreaseSalary(p);

            Console.WriteLine();
            Console.WriteLine("updated data: " + emp1);
        }
    }
}
