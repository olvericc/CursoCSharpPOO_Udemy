using System;

namespace StructType {
    internal class Program {
        static void Main(string[] args) {

            // declaration
            Point p;

            // instantiation
            p.x = 10;
            p.y = 20;

            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);
        }
    }
}
