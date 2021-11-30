using System;

namespace RepetitiveStructureFOR {
    internal class Program {
        static void Main(string[] args) {

            // repetitive structure 'for'

            Console.Write("How many whole numbers are you going to type? ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++) {
                Console.Write("value #" + i + " : ");
                int value = int.Parse(Console.ReadLine());
                sum += value;
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
