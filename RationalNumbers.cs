namespace Operators
{
    internal class RationalNumbers
    {
        public long numerator { get; }
        public long denominator { get; }

        public RationalNumbers(long numerator, long denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен нулю.");
            }

            this.numerator = numerator;
            this.denominator = denominator;
        }

        public static RationalNumbers operator +(RationalNumbers a, RationalNumbers b)
        {
            long numerator = a.numerator * b.denominator + b.numerator * a.denominator;
            long commonDenominator = a.denominator * b.denominator;

            return new RationalNumbers(numerator, commonDenominator);
        }

        public static RationalNumbers operator -(RationalNumbers a, RationalNumbers b)
        {
            long numerator = a.numerator * b.denominator - b.numerator * a.denominator;
            long commonDenominator = a.denominator * b.denominator;

            return new RationalNumbers(numerator, commonDenominator);
        }

        public static RationalNumbers operator *(RationalNumbers a, RationalNumbers b)
        {
            long numerator = a.numerator * b.numerator;
            long denominator = a.denominator * b.denominator;

            return new RationalNumbers(numerator, denominator);
        }

        public static RationalNumbers operator /(RationalNumbers a, RationalNumbers b)
        {
            if (b.numerator == 0)
            {
                throw new DivideByZeroException("Знаменатель не может быть равен нулю.");
            }

            long numerator = a.numerator * b.denominator;
            long denominator = a.denominator * b.numerator;

            return new RationalNumbers(numerator, denominator);
        }

        public static bool operator >(RationalNumbers a, RationalNumbers b)
        {
            return a.numerator * b.denominator > b.numerator * a.denominator;
        }

        public static bool operator <(RationalNumbers a, RationalNumbers b)
        {
            return a.numerator * b.denominator < b.numerator * a.denominator;
        }

        public static bool operator ==(RationalNumbers a, RationalNumbers b)
        {
            return a.numerator * b.denominator == b.numerator * a.denominator;
        }

        public static bool operator !=(RationalNumbers a, RationalNumbers b)
        {
            return a.numerator * b.denominator != b.numerator * a.denominator;
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }
    }
}