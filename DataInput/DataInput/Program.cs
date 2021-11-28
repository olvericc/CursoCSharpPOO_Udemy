using System;

namespace DataInput {
    internal class Program {
        static void Main(string[] args) {

            // reading

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();  
            string z = Console.ReadLine();

            Console.WriteLine("you write: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            // split
            Console.WriteLine("---------");
            string[] vet = Console.ReadLine().Split(' ');
            string a = vet[0];
            string b = vet[1];  
            string c = vet[2];
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
