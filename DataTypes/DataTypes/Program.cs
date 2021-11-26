using System;

namespace DataTypes {
    internal class Program {
        static void Main(string[] args) {

            // Value types - integers

            // type sbyte or SByte
            SByte x = 100;
            Console.WriteLine("sbyte: " + x);

            // byte - DON'T HAVE SIGNAL NEGATIVE
            // byte N = -1; wrong
            // byte 0 - 255;
            byte n1 = 255;
            n1++;
            Console.WriteLine("byte: " + n1);

            // Overflow example
            sbyte ex1 = 127;
            ex1++;
            Console.WriteLine("example overflow: " + ex1);

            // int
            int n2 = 1000;
            Console.WriteLine("int: " + n2);
            // int n3 = 2147483647; max value suported
            // Console.WriteLine(n3)

            // long
            long n4 = 2147483648L; // L/l -> at the end of the number
            Console.WriteLine("long: " + n4);

            // short
            short n5 = 32766;
            // short n6 = 32768; max value suported
            Console.WriteLine("short: " + n5);

            // bool - true or false
            bool complete = false;
            Console.WriteLine("value: " + complete);

            // char - just one character
            // use simple quotes ''
            char genre = 'f';
            Console.WriteLine("genre: " + genre);
            // unicode example 
            char letter = '\u0041'; // \u0041 -> A
            Console.WriteLine("letter: " + letter);

            //-------------------------------------------------//

            // Values types - floating point
            
            // float
            float n7 = 4.5F; // F/f -> at the end of the number
            Console.WriteLine("float: " + n7);

            // double
            double n8 = 2.7;
            Console.WriteLine("double: " + n8);

            //-------------------------------------------------//

            // Reference types

            // use double quotes
            // string - character grouping
            string name = "eric";
            Console.WriteLine("name: " + name);

            // object - generic type
            // accept any value
            object obj1 = "alex";
            object obj2 = 4.8f;
            Console.WriteLine("objects: " + obj1 + ", " + obj2);

            //-------------------------------------------------//

            // max values and min values

            // int.MinValue
            int a1 = int.MinValue;
            Console.WriteLine("minimum value for int: " + a1);

            // int.MaxValue
            int a2 = int.MaxValue;
            Console.WriteLine("maximum value for int: " + a2);

            // sbyte.MinValue
            sbyte a3 = sbyte.MinValue;
            Console.WriteLine("minimum value of sbyte: " + a3);

            // decimal.MaxValue
            decimal a4 = decimal.MaxValue;
            Console.WriteLine("maximum value of decimal: " + a4);
        }
    }
}
