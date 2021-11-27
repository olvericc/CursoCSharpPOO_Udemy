using System;

namespace ImplicitConversationAndCasting {
    internal class Program {
        static void Main(string[] args) {

            // implicit conversation 

            float x = 4.5f; // have 4 bytes
            double y = x;   // have 8 bytes
            Console.WriteLine(y);

            // inverse process

            double a;
            float b;
            a = 5.1;
            //b = a; wrong
            b = (float)a;
            Console.WriteLine(b);

            // example 1
            double c;   // 8 bytes
            int d;      // 4 bytes
            c = 7.9;
            // d = c; wrong -> loss of information!!!!
            d = (int)c;
            Console.WriteLine(d);

            // example 2
            int var1 = 5;
            int var2 = 2;
            // double result = var1 / var2; wrong result
            double result = (double)var1 / var2;
            Console.WriteLine(result);
        }
    }
}
