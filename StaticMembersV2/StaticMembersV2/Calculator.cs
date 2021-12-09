using System;

namespace StaticMembersV2 {
    internal class Calculator {

        public double Pi = 3.14;

        public double Circuference(double r) {
            return 2.0 * Pi * r;
        }

        public double Volume(double r) {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}
