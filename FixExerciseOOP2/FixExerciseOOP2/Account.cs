using System;
using System.Globalization;

namespace FixExerciseOOP2 {
    class Account {

        // class attributes
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }

        // default builder
        public Account() {
        }

        // constructor with two arguments
        public Account(int number, string holder) {
            Number = number;
            Holder = holder;
        }

        // constructor with three arguments using  ': this'
        public Account(int number, string holder, double balance) : this(number, holder) {
            Balance = balance;
        }

        // method Deposit()
        public void Deposit(double amount) {
            Balance += amount;
        }

        // method Withdraw()
        public void Withdraw(double amount) {
            Balance -= amount;
            Balance -= 5.0; // tax of $ 5.0
        }

        // method ToSting()
        public override string ToString() {
            return "Account number: "
                + Number
                + ", Holder name: "
                + Holder
                + " , Balance: $ "
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
