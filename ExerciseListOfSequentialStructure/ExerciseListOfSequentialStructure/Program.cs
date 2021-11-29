using System;
using System.Globalization;

namespace ExerciseListOfSequentialStructure {
    internal class Program {
        static void Main(string[] args) {

            // question no1

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int sum;

            sum = n1 + n2;

            Console.WriteLine("SUM: " + sum);

            // question no2

            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double PI = 3.14159;
            double area = PI * Math.Pow(radius, 2);

            Console.WriteLine("Area: " + area.ToString("F4", CultureInfo.InvariantCulture));

            // question no3

            int A, B, C, D;
            int DIF;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            DIF = (A * B) - (C * D);

            Console.WriteLine("DIF: " + DIF);

            // question no4

            int idEmployee = int.Parse(Console.ReadLine());
            int workedHours = int.Parse(Console.ReadLine());
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
            double salary = workedHours * valuePerHour;

            Console.WriteLine("NUMBER: " + idEmployee);
            Console.WriteLine("SALARY: U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));

            // question no5

            int codePiece1, codePiece2, numberPiece1, numberPiece2;
            double valuePiece1, valuePiece2, payment;

            string[] values = Console.ReadLine().Split(' ');
            codePiece1 = int.Parse(values[0]);
            numberPiece1 = int.Parse(values[1]);
            valuePiece1 = double.Parse(values[2], CultureInfo.InvariantCulture);
           
            values = Console.ReadLine().Split(' ');    
            codePiece2 = int.Parse(values[0]);
            numberPiece2 = int.Parse(values[1]);
            valuePiece2 = double.Parse(values[2], CultureInfo.InvariantCulture);

            payment = (numberPiece1 * valuePiece1) + (numberPiece2 * valuePiece2);

            Console.WriteLine("TOTAL PAYABLE: U$ " + payment.ToString("F2", CultureInfo.InvariantCulture));

            // question no6

            double a, b, c;
            double triangleArea, circleArea, trapezeArea, squareArea, retangleArea;
            double pi = 3.14159;

            string[] v = Console.ReadLine().Split(' ');
            a = double.Parse(v[0], CultureInfo.InvariantCulture);
            b = double.Parse(v[1], CultureInfo.InvariantCulture);
            c = double.Parse(v[2], CultureInfo.InvariantCulture);

            // triangle area
            triangleArea = a * c / 2;

            // circle area
            circleArea = pi * Math.Pow(c, 2);

            // trapeze area
            trapezeArea = (a + b) * c / 2;

            // square area
            squareArea = Math.Pow(b, 2);

            // retangle area
            retangleArea = a * b;

            Console.WriteLine("Triangle: " + triangleArea.ToString("F3" , CultureInfo.InvariantCulture));
            Console.WriteLine("Circle: " + circleArea.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapeze: " + trapezeArea.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Square: " + squareArea.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retangle: " + retangleArea.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
