using System;

namespace FunctionsSintax {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("enter with three numbers: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            /*
                if (n1 > n2 && n1 > n3) {
                    Console.WriteLine("bigger = " + n1);
                }
                else if (n2 > n3) {
                    Console.WriteLine("bigger = " + n2);
                } 
                else {
                    Console.WriteLine("bigger = " + n3);
                }
            */

            double result = Bigger(n1, n2, n3);

            Console.WriteLine("bigger = " + result);
        }

        static int Bigger(int a, int b, int c) {
            int big;

            if (a > b && a > c) {
                big = a;
            } 
            else if (b > c) {
                big = b;
            } 
            else {
                big = c;
            }
            return big;
        }
    }
}
