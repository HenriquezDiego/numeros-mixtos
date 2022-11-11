namespace Main
{
    public class NumeroMixto
    {
        private readonly int _number;
        private readonly Fraccion _fraction;

        public NumeroMixto(int number, Fraccion fraction)
        {
            _number = number;
            _fraction = fraction;
        }

        public NumeroMixto(int number, int numerator, int denominator)
        {
            _number = number;
            _fraction = new Fraccion(numerator, denominator);
        }

        private int Number()
        {
            return _number;
        }

        private Fraccion Fraction()
        {
            return _fraction;
        }

        public Fraccion ConvertToFraccion()
        {
            var d = Fraction().Denominator();
            var n = Math.Abs(Number()) * d + Fraction().Numerator();
            n = Number() < 0 ? -n : n;
            return new Fraccion(n, d);
        }

        public override string ToString()
        {
            return $"{Number()} {Fraction().Numerator()}/{Fraction().Denominator()}";
        }
    }
}