using System;

namespace AssignmentOperators {
    internal class Program {
        static void Main(string[] args) {

            // assignment operator '='
            int a = 10;
            Console.WriteLine(a);

            // cumulative assignment operators
            // operator +=
            a += 2;
            Console.WriteLine(a);

            // operator -=
            a -= 2;
            Console.WriteLine(a);

            // operator *=
            a *= 2;
            Console.WriteLine(a);

            // operator /=
            a /= 2;
            Console.WriteLine(a);

            // operator %= mod
            a %= 3;
            Console.WriteLine(a);

            // operator += for string
            string s = "ABC";
            Console.WriteLine(s);
            s += "DEF";
            Console.WriteLine(s);

            // arithmetic/assignment operators
            // operator ++
            int b = 10;
            ++b; // or use b++;
            Console.WriteLine("b = " + b);

            // operator --
            int c = 10;
            --c; // or use c--;
            Console.WriteLine("c = " + c);

            // example
            int x = 10;
            int y = ++x; // x++
            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
        }
    }
}
