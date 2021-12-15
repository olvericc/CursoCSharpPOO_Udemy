using System;
using System.Globalization;

namespace FixExerciseOOP2 {
    internal class Program {
        static void Main(string[] args) {

            // instantiation
            Account acc1 = new Account();

            Console.Write("enter with account number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("enter with account holder name: ");
            string holder = Console.ReadLine();
            Console.Write("will there be initial deposit (y/n)? ");
            char r = char.Parse(Console.ReadLine());

            // decision structure for char r
            if (r == 'y' || r == 'S') {
                Console.Write("enter with initial deposit value: ");
                double initialDeposit = double.Parse(Console.ReadLine()
                    , CultureInfo.InvariantCulture);
                acc1 = new Account(number, holder, initialDeposit);
            }
            else {
                acc1 = new Account(number, holder);
            }

            Console.WriteLine();
            Console.WriteLine("account data: ");
            Console.WriteLine(acc1);

            // deposit
            Console.WriteLine();
            Console.Write("enter with deposit value: ");
            double amount = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            acc1.Deposit(amount);
            Console.WriteLine("updated account data: ");
            Console.WriteLine(acc1);
            // withdraw
            Console.WriteLine();
            Console.Write("enter with withdraw value: ");
            amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            acc1.Withdraw(amount);
            Console.WriteLine("updated account data: ");
            Console.WriteLine(acc1);

        }
    }
}
