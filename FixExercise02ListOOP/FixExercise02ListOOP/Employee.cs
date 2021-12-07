using System;
using System.Globalization;

namespace FixExercise02ListOOP {
    internal class Employee {

        // class attributes
        public string Name;
        public double GrossSalary;
        public double Tax;

        // method LiquidSalary()
        public double LiquidSalary() {
            return GrossSalary - Tax;
        }

        // method IncreaseSalary()
        public void IncreaseSalary(double percentage) {
            GrossSalary = GrossSalary + (GrossSalary * percentage / 100.0);
        }

        // method ToString()
        public override string ToString() {
            return Name
                + ", $ "
                + LiquidSalary().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
