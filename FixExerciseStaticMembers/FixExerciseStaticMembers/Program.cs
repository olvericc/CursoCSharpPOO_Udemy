using System;
using System.Globalization;

namespace FixExerciseStaticMembers {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("what is the dollar rate? ");
            double rate = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("how many dollars you gonna buy? ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = CurrencyConverter.DollarForReal(amount, rate);

            Console.WriteLine("value to be pay in real: " + result.ToString("F2",
                CultureInfo.InvariantCulture));
        }
    }
}
