using System;

namespace Matrix {
    internal class Program {
        static void Main(string[] args) {

            // creating a matrix
            double[,] mat = new double[2, 3];

            // length
            Console.WriteLine(mat.Length);

            // rank
            Console.WriteLine(mat.Rank);

            // getLenght1
            Console.WriteLine(mat.GetLength(0));

            // getLength2
            Console.WriteLine(mat.GetLength(1));

        }
    }
}
