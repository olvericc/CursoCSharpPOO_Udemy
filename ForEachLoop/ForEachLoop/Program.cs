using System;

namespace ForEachLoop {
    internal class Program {
        static void Main(string[] args) {

            string[] vect = new string[] { "maria", "alex", "bob" };

            for (int i = 0; i < vect.Length; i++) {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("--------------------------------"); 

            foreach (string x in vect) {
                Console.WriteLine(x);
            }
        }
    }
}
