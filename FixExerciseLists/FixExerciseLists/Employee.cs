using System.Globalization;

namespace FixExerciseLists {
    class Employee {

        // class attributes
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        // default builder
        public Employee() {
        }

        // constructor with three arguments
        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        // method IncreaseSalary()
        public void IncreaseSalary(double percentage) {
            Salary += Salary * percentage / 100.0;
        }

        // method ToString()
        public override string ToString() {
            return Id +
                ", " +
                Name +
                ", " +
                Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
