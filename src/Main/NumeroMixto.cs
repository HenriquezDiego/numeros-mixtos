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

        public static NumeroMixto operator +(NumeroMixto a, NumeroMixto b)
        {
            return Operacion(a,b,'+');
        }

        public static NumeroMixto operator -(NumeroMixto a, NumeroMixto b)
        {
            return Operacion(a,b,'-');
        }

        public static NumeroMixto operator *(NumeroMixto a, NumeroMixto b)
        {
            return Operacion(a,b,'*');
        }

        public static NumeroMixto operator /(NumeroMixto a, NumeroMixto b)
        {
            return Operacion(a,b,'/');
        }

        private static NumeroMixto Operacion(NumeroMixto a, NumeroMixto b,char op)
        {
            var f1 = a.ConvertToFraccion();
            var f2 = b.ConvertToFraccion();
            var f3 = op switch
            {
                '+' => f1 + f2,
                '-' => f1 - f2,
                '*' => f1 * f2,
                '/' => f1 / f2,
                _ => throw new ArgumentOutOfRangeException(nameof(op), op, null)
            };
            return f3.Simplify().ConvertToMixedFraccion();
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