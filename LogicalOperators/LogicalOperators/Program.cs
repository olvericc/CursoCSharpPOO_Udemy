using System;

namespace LogicalOperators {
    internal class Program {
        static void Main(string[] args) {

            // logical operators

            bool c1 = 4 != 5;   // true
            Console.WriteLine(c1); 

            // operator '&&'

            bool c2 = 2 > 3 && 4 != 5; // false
            Console.WriteLine(c2);

            // operator '||'

            bool c3 = 2 > 3 || 4!= 5; // true
            Console.WriteLine(c3);

            // operator '!'

            bool c4 = !(2 > 3) && 4 != 5; // true
            Console.WriteLine(c4);

            // example
            Console.WriteLine("---------");
            bool c5 = 10 < 5; // false
            bool c6 = c3 || c4 && c5; // true
            Console.WriteLine(c5);
            Console.WriteLine(c6);
        }
    }
}
