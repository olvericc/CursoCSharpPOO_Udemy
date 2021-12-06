using System;

namespace ExampleProblemWithOO {
    internal class Triangle {

        // class attributes
        public double A;
        public double B;
        public double C;

        // method Area()
        
        public double Area() {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
