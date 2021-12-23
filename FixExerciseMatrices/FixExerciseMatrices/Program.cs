using System;

namespace FixExerciseMatrices {
    internal class Program {
        static void Main(string[] args) {

            string[] l = Console.ReadLine().Split(' ');
            int m = int.Parse(l[0]); // lines
            int n = int.Parse(l[1]); // columns

            int[,] matrix = new int[m, n];

            for (int i = 0; i < m; i++) {
                string[] v = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    matrix[i, j] = int.Parse(v[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (matrix[i, j] == x) {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0) {
                            Console.WriteLine("Left: " + matrix[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up: " + matrix[i - 1, j]);
                        }
                        if (j < n - 1) {
                            Console.WriteLine("Right: " + matrix[i, j + 1]);
                        }
                        if (i < m - 1) {
                            Console.WriteLine("Down: " + matrix[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
