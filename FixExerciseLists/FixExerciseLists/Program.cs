using System;
using System.Collections.Generic;
using System.Globalization;

namespace FixExerciseLists {
    internal class Program {
        static void Main(string[] args) {

            // creating a list
            List<Employee> list = new List<Employee>();

            // reading a N variable
            Console.Write("how many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            // for struct 
            for (int i = 1; i <= n; i++) {
                Console.WriteLine("emloyee #" + i + ":");
                Console.Write("id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("name: ");
                string name = Console.ReadLine();
                Console.Write("salary: ");
                double salary = double.Parse(Console.ReadLine(),
                    CultureInfo.InvariantCulture);

                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("enter the employee id that will have salary increase: ");
            int sId = int.Parse(Console.ReadLine());

            // .Find
            Employee emp = list.Find(x => x.Id == sId);

            if (emp != null) {
                Console.Write("enter the percentage: ");
                double p = double.Parse(Console.ReadLine(),
                    CultureInfo.InvariantCulture);
                emp.IncreaseSalary(p);
            } else {
                Console.WriteLine("this id does not exist!");
            }

            // updated employee data
            Console.WriteLine();
            Console.WriteLine("updated list of employees: ");

            // printing the list
            foreach (Employee x in list) {
                Console.WriteLine(x);
            }
        }
    }
}
