using System;

namespace StaticMembersV3 {
    internal class Calculator {

        public static double Pi = 3.14;

        public static double Circuference(double r) {
            return 2.0 * Pi * r;
        }

        public static double Volume(double r) {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}
