using System;
using System.Globalization;

namespace DataInput2 {
    internal class Program {
        static void Main(string[] args) {
            
            // Reading a int number 
            
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("you write: " + n1);
                    
            // Reading a char
            
            char ch = char.Parse(Console.ReadLine());

            Console.WriteLine("you write: " + ch);

            // Reading a double number using CultureInfo

            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("you write: " + n2.ToString("F2" ,CultureInfo.InvariantCulture));

            // example reading a string, char, int and double 
            // split

            string[] vet = Console.ReadLine().Split(' ');
            string name = vet[0];
            char sex = char.Parse(vet[1]);
            int age = int.Parse(vet[2]);
            double height = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("-----------");
            Console.WriteLine("you write: ");
            Console.WriteLine(name);
            Console.WriteLine(sex);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
