using System;

namespace ParamModifier {
    class Program {
        static void Main(string[] args) {

            int s1 = Calculator.Sum( 2, 3 );
            int s2 = Calculator.Sum( 1, 2, 3 );

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
