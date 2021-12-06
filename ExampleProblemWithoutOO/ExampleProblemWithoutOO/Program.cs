﻿using System;
using System.Globalization;

namespace ExampleProblemWithoutOO {
    internal class Program {
        static void Main(string[] args) {

            double xA, xB, xC; // triangle x
            double yA, yB, yC; // triangle y

            Console.WriteLine("enter with the measures of triangle x:");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("enter with the measures of triangle y:");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Area of triangle x: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area of triangle y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("greater area: X");
            } 
            else {
                Console.WriteLine("greater area: Y");
            }
        }
    }
}
