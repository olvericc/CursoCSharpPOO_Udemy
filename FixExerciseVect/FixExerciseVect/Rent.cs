namespace FixExerciseVect {
    class Rent {

        // class attributes
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }

        // default builder
        public Rent() {
        }

        // constructor with two arguments
        public Rent(string studentName, string studentEmail) {
            StudentName = studentName;
            StudentEmail = studentEmail;
        }

        // method ToString()
        public override string ToString() {
            return StudentName + ", " + StudentEmail;
        }
    }
}
