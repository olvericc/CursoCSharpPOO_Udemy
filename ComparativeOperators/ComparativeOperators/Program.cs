using System;

namespace ComparativeOperators {
    internal class Program {
        static void Main(string[] args) {

            // comparative operators

            // operator less than  '<'
            
            int a = 10;
            bool c1 = a < 10;
            Console.WriteLine(c1); // false

            bool c2 = a < 20;
            Console.WriteLine(c2); // true

            // operator bigger than  '>'

            bool c3 = a > 10;
            Console.WriteLine(c3); // false

            bool c4 = a > 5;
            Console.WriteLine(c4); // true

            Console.WriteLine("---------------");

            // operator smaller equal to '<='

            bool c5 = a <= 10;
            Console.WriteLine(c5);

            // operator greater equal to '>='

            bool c6 = a >= 10;
            Console.WriteLine(c6);

            // operator equal to '=='

            bool c7 = a == 10;
            Console.WriteLine(c7);

            // operator different to '!='

            bool c8 = a != 10;
            Console.WriteLine(c8);
        }
    }
}
