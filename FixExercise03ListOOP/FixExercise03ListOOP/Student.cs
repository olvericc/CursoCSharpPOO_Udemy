using System;
using System.Globalization;

namespace FixExercise03ListOOP {
    internal class Student {

        // class attributes
        public string Name;
        public double Grade1;
        public double Grade2;
        public double Grade3;

        // method FinalGrade()
        public double FinalGrade() {
            return Grade1 + Grade2 + Grade3;
        }

        // method Situation()
        public bool Situation() {
            if (FinalGrade() >= 60.0) {
                return true;
            } else {
                return false;
            }
        }

        // method RemainingGrade()
        public double RemainingGrade() {
            if (Situation()) {
                return 0.0;
            } else {
                return 60.0 - FinalGrade();
            }
        }
    }   
}
