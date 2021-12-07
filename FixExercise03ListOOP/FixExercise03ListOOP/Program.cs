using System;
using System.Globalization;

namespace FixExercise03ListOOP {
    internal class Program {
        static void Main(string[] args) {

            // fixation exercise 03
            
            // instatiation
            Student s = new Student();

            Console.Write("student name: ");
            s.Name = Console.ReadLine();
            Console.WriteLine("enter with the student's three grades: ");
            s.Grade1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            s.Grade2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            s.Grade3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("final grade: " + s.FinalGrade().ToString("F2", CultureInfo.InvariantCulture));

            if (s.Situation()) {
                Console.WriteLine("approved!");
            } else {
                Console.WriteLine("disapproved!");
                Console.WriteLine("missed " 
                    + s.RemainingGrade().ToString("F2", CultureInfo.InvariantCulture) 
                    + " points...");
            }
        }
    }
}
