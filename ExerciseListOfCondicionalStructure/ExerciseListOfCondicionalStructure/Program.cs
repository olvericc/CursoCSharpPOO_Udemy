using System;
using System.Globalization;

namespace ExerciseListOfCondicionalStructure {
    internal class Program {
        static void Main(string[] args) {

            // fixation exercise of condicional structure

            // question no1

            /*
             
                int x = int.Parse(Console.ReadLine());

                if (x < 0) {
                    Console.WriteLine("negative!");
                } 
                else {
                    Console.WriteLine("positive!");
                }

            */

            // question no2

            /*
            
                int y = int.Parse(Console.ReadLine());

                if (y % 2 == 0) {
                    Console.WriteLine("pair");
                } 
                else {
                    Console.WriteLine("odd");
                }

            */

            // question no3

            /*
            
                string[] vet = Console.ReadLine().Split(' ');
                int a = int.Parse(vet[0]);  
                int b = int.Parse(vet[1]);

                if (a % b == 0 || b % a == 0) {
                    Console.WriteLine("are multiple");
                } 
                else {
                    Console.WriteLine("are not multiple");
                }

            */

            // question no4

            /*
            
                int duration;
                string[] va = Console.ReadLine().Split(' ');
                int initialHour = int.Parse(va[0]);
                int finalHour = int.Parse(va[1]);

                if (initialHour < finalHour) {
                    duration = finalHour - initialHour;
                } 
                else {
                    duration = 24 - initialHour + finalHour;
                }

                Console.WriteLine("the game lasted " + duration + " hour(s)");

            */

            // question no5

            /*
             
                string[] input = Console.ReadLine().Split(' '); 
                int code = int.Parse(input[0]);
                int quantity = int.Parse(input[1]);
            
                double total = 0;

                if (code == 1) { // hotdog
                    total = 4.00 * quantity;
                } 
                else if (code == 2) { // x salad
                    total = 4.50 * quantity;
                } 
                else if (code == 3) { // x bacon
                    total = 5.00 * quantity;
                } 
                else if (code == 4) { // simple toast
                    total = 2.00 * quantity;
                } 
                else if (code == 5) { // soda
                    total = 1.50 * quantity;
                } 
                else {
                    Console.WriteLine("please choose a number in interval of 1 to 5");
                }

                Console.WriteLine("total: U$ " + total.ToString("F2", CultureInfo.InvariantCulture));

            */

            // question no6

            /*

                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (value >= 0 && value <= 25.00) {
                    Console.WriteLine("interval [0, 25]");
                }
                else if (value >= 25.00 && value <= 50.00) {
                    Console.WriteLine("interval [25, 50]");
                }
                else if (value >= 50.00 && value <= 75.00) {
                    Console.WriteLine("interval [50, 75]");
                }
                else if (value >= 75.00 && value <= 100.00) {
                    Console.WriteLine("interval [75, 100]");
                }
                else {
                    Console.WriteLine("out of range");
                }

            */

            // question no7

            /*

                string[] v = Console.ReadLine().Split(' ');
                double X = double.Parse(v[0], CultureInfo.InvariantCulture);
                double Y = double.Parse(v[1], CultureInfo.InvariantCulture);

                if (X > 0 && Y > 0) {
                    Console.WriteLine("Q1");
                } 
                else if (X > 0 && Y > 0) {
                    Console.WriteLine("Q2");
                } 
                else if (X < 0 && Y < 0) {
                    Console.WriteLine("Q3");
                } 
                else if (X > 0 && Y < 0) {
                    Console.WriteLine("Q4");
                } 
                else if (X == 0 && Y == 0) {
                    Console.WriteLine("source");
                } 
                else {
                    Console.WriteLine("wrong values, please try again");
                }

            */

            // question no8

            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double tax;
            if (salary <= 2000.0) {
                tax = 0.0;
            } else if (salary <= 3000.0) {
                tax = (salary - 2000.0) * 0.08;
            } else if (salary <= 4500.0) {
                tax = (salary - 3000.0) * 0.18 + 1000.0 * 0.08;
            } else {
                tax = (salary - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (tax == 0.0) {
                Console.WriteLine("free");
            } else {
                Console.WriteLine("U$ " + tax.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
