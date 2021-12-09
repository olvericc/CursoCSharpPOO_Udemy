namespace FixExerciseStaticMembers {
    internal class CurrencyConverter {

        public static double IOF = 6.0;

        public static double DollarForReal(double amount, double rate) {
            double calc = amount * rate ;
            return calc + calc * IOF / 100.0;
        }
    }
}
