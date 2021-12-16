using System;

namespace Nullable {
    internal class Program {
        static void Main(string[] args) {

            // double x = null; double is not nullable
            double? x = null; // or Nullable<double> x =  null;
            double? y = 10.0;
            //bool? z = null;

            // method GetValueOrDefault()

            Console.WriteLine(x.GetValueOrDefault());
            //Console.WriteLine(z.GetValueOrDefault());

            Console.WriteLine(y.GetValueOrDefault());

            // method HasValue

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            // method Value

            if (x.HasValue) {
                Console.WriteLine(x.Value);
            } else {
                Console.WriteLine("x is null!");
            }

            if (y.HasValue) {
                Console.WriteLine(y.Value);
            } else {
                Console.WriteLine("y is null!");
            }

            // null-coalescing operator
            double? value1 = null;
            double? value2 = 10;
            double a = value1 ?? 5;
            double b = value2 ?? 5;
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
