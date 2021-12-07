using System;

namespace FixExercise01ListOOP {
    internal class Retangle {

        // class attributes
        public double Width;
        public double Height;

        // method Area()
        public double Area() {
            return Height * Width;
        }

        // method Perimeter()
        public double Perimeter() {
            return 2 * (Height + Width);
        }

        // method Diagonal()
        public double Diagonal() {
            return Math.Sqrt(Width * Width + Height * Height);
        }
    }
}
