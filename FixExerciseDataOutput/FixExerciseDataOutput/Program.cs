using System;
using System.Globalization;

namespace FixExerciseDataOutput {
    internal class Program {
        static void Main(string[] args) {

            // fixation exercise

            string product1 = "Computer";
            string product2 = "Office desk";

            byte age = 30;
            int id = 5290;
            char genre = 'M';

            double price1 = 2100.00;
            double price2 = 650.50;
            double measure = 53.234567;

            Console.WriteLine("Products:");
            Console.WriteLine(product1 + ", whose price is $ " + price1);
            Console.WriteLine(product2 + ", whose price is $ " + price2);
            Console.WriteLine();
            Console.WriteLine("Record: " + age + " years old, id " + id + " and genre: " + genre);
            Console.WriteLine();
            Console.WriteLine("Measure whit eight decimal places: " + measure.ToString("F8"));
            Console.WriteLine("Rounded (three decimal places): " + measure.ToString("F3"));
            Console.WriteLine("Decimal separator invariant culture: " + measure.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
