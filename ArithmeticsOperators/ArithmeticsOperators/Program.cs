﻿using System;

namespace ArithmeticsOperators {
    internal class Program {
        static void Main(string[] args) {

            // arithmetics operators

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = (double)10 / 8;
            // or use double n4 = 10.0 / 8.0;

            // bhaskara
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = (b * b) - 4.0 * a * c;
            // or use a math.Pow(b, 2.0) -> (b*b)
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine("result delta: " + delta);
            Console.WriteLine("x1: " + x1);
            Console.WriteLine("x2: " + x2);
            
        }
    }
}
