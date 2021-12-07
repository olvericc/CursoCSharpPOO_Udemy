using System;
using System.Globalization;

namespace Exercise02ListOO {
    internal class Program {
        static void Main(string[] args) {
            
            // exercise 02

            // instantiation
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            Console.WriteLine("first employee data:");
            Console.Write("name: ");
            emp1.Name = Console.ReadLine();
            Console.Write("salary: ");
            emp1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("second employee data:");
            Console.Write("name: ");
            emp2.Name = Console.ReadLine();
            Console.Write("salary: ");
            emp2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double avarageSalary = (emp1.Salary + emp2.Salary) / 2.0;

            Console.WriteLine("avarage salary: " + avarageSalary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
