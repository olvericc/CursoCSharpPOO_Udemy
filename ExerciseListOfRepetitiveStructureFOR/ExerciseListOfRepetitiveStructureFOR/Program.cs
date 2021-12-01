using System;
using System.Globalization;

namespace ExerciseListOfRepetitiveStructureFOR {
    internal class Program {
        static void Main(string[] args) {

            // question no1

            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }    

            // question no2

            int N = int.Parse(Console.ReadLine());

            int contIn = 0;
            int contOut = 0;

            for (int i = 0; i < N; i++) {
                int number = int.Parse(Console.ReadLine());
                if (number >= 10 && number <= 20) {
                    contIn++;
                } 
                else {
                    contOut++;
                }
            }

            Console.WriteLine(contIn + " in");
            Console.WriteLine(contOut + " out");

            // question no3

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                string[] v = Console.ReadLine().Split(' ');
                double a = double.Parse(v[0], CultureInfo.InvariantCulture);
                double b = double.Parse(v[1], CultureInfo.InvariantCulture);
                double c = double.Parse(v[2], CultureInfo.InvariantCulture);

                double weightedAverage = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(weightedAverage.ToString("F1"));
            }
            
            // question no4
  
            int numberN = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberN; i++) {
                string[] vect = Console.ReadLine().Split(' ');
                int numerator = int.Parse(vect[0]);
                int denominator = int.Parse(vect[1]);
                double calc = 0;
                if (denominator == 0) {
                    Console.WriteLine("impossible division!");
                } 
                else {
                    calc = (double)numerator / denominator;
                    Console.WriteLine(calc.ToString("F1", CultureInfo.InvariantCulture));
                }          
            }

            // question no5
            
            int q = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int i = 1; i <= q; i++) {
                fat = fat * i;
            }
            Console.WriteLine(fat);
            
            // question no6
            
            int j = int.Parse(Console.ReadLine());

            for (int i = 1; i <= j; i++) {
                if (j % i == 0) {
                    Console.WriteLine(i);
                }    
            }
            
            // question no7

            int U = int.Parse(Console.ReadLine());

            for (int i = 1; i <= U; i++) {

                int first = i;
                int second = i * i;
                int third = i * i * i;
                Console.WriteLine($"{first} {second} {third}");
            }
        }
    }
}
