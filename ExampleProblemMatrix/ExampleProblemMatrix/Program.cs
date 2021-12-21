using System;

namespace ExampleProblemMatrix {
    internal class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];
            // lines
            for (int i = 0; i < n; i++) {
                string[] values = Console.ReadLine().Split(' ');
                // columns
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            // main diagonal
            Console.WriteLine("main diagonal: ");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i,i] + " ");
            }
            Console.WriteLine();

            // negative numbers

            int count = 0;
            for (int i = 0; i < n; i++) {

                for (int j = 0; j < n; j++) {

                    if (mat[i, j] < 0) {
                        count++;
                    }
                }
            }
            Console.WriteLine("negative numbers: " + count);
        }
    }
}
