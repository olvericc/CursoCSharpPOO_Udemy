using System;
using System.Globalization;

namespace DataOutput {
    internal class Program {
        static void Main(string[] args) {

            // write
            // no break line
            Console.Write("Bom dia!");

            // writeline
            // breakline
            Console.WriteLine("Boa noite!");
            Console.WriteLine("Boa tarde!");

            // printing variables
            char genre = 'f';
            int age = 32;
            double balance = 10.536;
            string name = "maria";

            Console.WriteLine("----------------------");
            Console.WriteLine(genre);
            Console.WriteLine(age);
            Console.WriteLine(balance);
            Console.WriteLine(name);
            // controlling the decimal places
            Console.WriteLine(balance.ToString("F2"));// two decimal places
            Console.WriteLine(balance.ToString("F4"));// four decimal places
            // printing with .
            Console.WriteLine(balance.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("----------------------");

            //----------------------------------------------------//

            // placeholders
            Console.WriteLine("{0} have " +
                "{1} years old and have balance equals a " +
                "{2:F2} dollars", name, age, balance);

            // interpolation
            Console.WriteLine($"{name} have " +
                $"{age} years old and have balance equals a " +
                $"{balance:F2} dollars");

            // concatenation
            Console.WriteLine
                (name +
                " have " +
                age +
                " years old and have balance equals a " + 
                balance.ToString("F2", CultureInfo.InvariantCulture) +
                " dollars");

        }
    }
}
