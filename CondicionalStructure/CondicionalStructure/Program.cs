using System;

namespace CondicionalStructure {
    internal class Program {
        static void Main(string[] args) {

            // condicional structure if-else

            int x = 10;
            
            Console.WriteLine("good morning");
            if (x > 5) {
                Console.WriteLine("good afternoon");
            }
            Console.WriteLine("good night");
            

            // example pair or odd, using if-else

            
            Console.WriteLine("enter with a integer number");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0) {
                Console.WriteLine("pair!");
            } 
            else {
                Console.WriteLine("odd!");
            }
            

            // example hour, using if-else_if-else

            Console.WriteLine("what is the current time?");
            int hour = int.Parse(Console.ReadLine());
            if (hour < 12) {
                Console.WriteLine("good morning!");
            }

            else if (hour < 18) {
                Console.WriteLine("good afternoon!");
            } 

            else {
                Console.WriteLine("good night");
            }
        }
    }
}
