using System;

namespace ScopeAndInicilization {
    internal class Program {
        static void Main(string[] args) {

            // inicialization!

            int x;
            x = 10;

            // or int x = 10;

            // wrong because the variable was not started

            /*
              
                int y;
                Console.WriteLine(y); // wrong!

            */

            // scope

            double price = double.Parse(Console.ReadLine());
            double descount = 0.0;
            if (price > 100.0) {
                descount = price * 0.1;
            }
            // wrong!
            //Console.WriteLine(descount); // don't exists in atual context
            Console.WriteLine(descount);
        }
    }
}
