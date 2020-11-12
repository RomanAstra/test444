namespace Lesson_2
{
    public class Fraction
    {
        private int _numerator;
        private int _denominator;

        public int Numerator
        {
            private get { return _numerator; }
            set
            {
                if (value > 0)
                {
                    _numerator = value;
                }
            }
        }

        public int Denominator
        {
            get { return _denominator; }
            set { _denominator = value; }
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            Fraction result = new Fraction();
            result.Numerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            result.Denominator = a.Denominator * b.Denominator;
            return result;
        }

        public void NameMethod()
        {
            int a, c, d;
            int b;
        }
    }
}
