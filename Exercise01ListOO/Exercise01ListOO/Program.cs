using System;

namespace Exercise01ListOO {
    internal class Program {
        static void Main(string[] args) {

            // instantiation
            People p1 = new People();
            People p2 = new People();

            // exercise 01

            Console.WriteLine("first person data: ");
            Console.Write("name: ");
            p1.Name = Console.ReadLine();
            Console.Write("age: ");
            p1.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("second person data: ");
            Console.Write("name: ");
            p2.Name = Console.ReadLine();
            Console.Write("age: ");
            p2.Age = int.Parse(Console.ReadLine());

            if (p1.Age > p2.Age) {
                Console.WriteLine("older person: " + p1.Name);
            }
            else if (p1.Age == p2.Age) {
                Console.WriteLine("persons with same age");
            } 
            else {
                Console.WriteLine("older person: " + p2.Name);
            }
        }
    }
}
