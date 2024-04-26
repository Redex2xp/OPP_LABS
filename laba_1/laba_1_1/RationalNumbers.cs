namespace laba_1_1
{
    class RationalNumbers
    {
        private readonly int _numerator;
        private readonly int _denominator;

        public RationalNumbers(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }

            int gcd = Gcd(numerator, denominator);
            _numerator = numerator / gcd;
            _denominator = denominator / gcd;
            if (_denominator < 0)
            {
                _numerator = -_numerator;
                _denominator = -_denominator;
            }
        }

        public int Numerator
        {
            get { return _numerator; }
        }

        public int Denominator
        {
            get { return _denominator; }
        }

        public override string ToString()
        {
            return $"{Numerator}/{_denominator}";
        }

        public static RationalNumbers operator +(RationalNumbers counter1, RationalNumbers counter2)
        {
            return new RationalNumbers(
                counter1._numerator * counter2._denominator + counter2._numerator * counter1._denominator,
                counter1._denominator * counter2._denominator);
        }

        public static RationalNumbers operator -(RationalNumbers counter1, RationalNumbers counter2)
        {
            return new RationalNumbers(
                counter1._numerator * counter2._denominator - counter2._numerator * counter1._denominator,
                counter1._denominator * counter2._denominator);
        }

        public static bool operator ==(RationalNumbers a, RationalNumbers b)
        {
            return a._numerator == b._numerator && a._denominator == b._denominator;
        }

        public static bool operator !=(RationalNumbers a, RationalNumbers b)
        {
            return !(a == b);
        }

        public static bool operator <(RationalNumbers a, RationalNumbers b)
        {
            return a._numerator * b._denominator < b._numerator * a._denominator;
        }

        public static bool operator >(RationalNumbers a, RationalNumbers b)
        {
            return a._numerator * b._denominator > b._numerator * a._denominator;
        }

        public static RationalNumbers operator -(RationalNumbers a)
        {
            return new RationalNumbers(-a._numerator, a._denominator);
        }

        private static int Gcd(int a, int b)
        {
            return b == 0 ? a : Gcd(b, a % b);
        }

    }
}