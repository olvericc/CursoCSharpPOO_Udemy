using System;

namespace FixExerciseVect {
    internal class Program {
        static void Main(string[] args) {

            // creating a vect
            Rent[] vect = new Rent[10];

            Console.Write("how many rooms will be rented: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                Console.WriteLine();
                Console.WriteLine("rent #" + i + ":");
                Console.Write("student name: ");
                string Sname = Console.ReadLine();
                Console.Write("student e-mail: ");
                string Semail = Console.ReadLine();
                Console.Write("room: ");
                int room = int.Parse(Console.ReadLine());

                vect[room] = new Rent(Sname, Semail);
            }
            Console.WriteLine();
            Console.WriteLine("busy rooms:");

            for (int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + " :" + vect[i]);
                }
            }
        }
    }
}
