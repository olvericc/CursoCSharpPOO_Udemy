using System;

namespace ExerciseListOfRepetitiveStructureWHILE {
    internal class Program {
        static void Main(string[] args) {

            // question no1

            int password = int.Parse(Console.ReadLine());

            while (password != 2002) {
                Console.WriteLine("incorrect password");
                password = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("allowed access");

            // question no2

            string[] vect = Console.ReadLine().Split(' ');
            int x = int.Parse(vect[0]);
            int y = int.Parse(vect[1]);

            while (x != 0 || y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("first");
                } 
                else if (x < 0 && y > 0) {
                    Console.WriteLine("second");
                } 
                else if (y < 0 && x < 0) {
                    Console.WriteLine("third");
                } 
                else if (x > 0 && y < 0) {
                    Console.WriteLine("fourth");
                }
                vect = Console.ReadLine().Split(' ');
                x = int.Parse(vect[0]);
                y = int.Parse(vect[1]);
            }

            // question no3

            int type = int.Parse(Console.ReadLine());
            int alcohol = 0;
            int gasoline = 0;
            int diesel = 0;

            while (type != 4) {
                if (type == 1) {
                    alcohol += 1;
                } else if (type == 2) {
                    gasoline += 1;
                } else if (type == 3) {
                    diesel += 1;
                }

                type = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Thanks so much!");
            Console.WriteLine("alcohol: " + alcohol);
            Console.WriteLine("gasoline: " + gasoline);
            Console.WriteLine("diesel: " + diesel);
        }
    }
}
