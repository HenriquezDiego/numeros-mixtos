namespace Main
{
    public class Fraccion
    {
        private readonly int _numerador;
        private readonly int _denominador;

        public Fraccion(int numerator, int denominador)
        {
            if (denominador == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.", nameof(denominador));
            }
            _numerador = numerator;
            _denominador = denominador;
        }

        public int Numerator()
        {
            return _numerador;
        }

        public int Denominator()
        {
            return _denominador;
        }

        public bool IsProper()
        {
            return _numerador < _denominador;
        }

        public static Fraccion operator +(Fraccion a) => a;

        public static Fraccion operator -(Fraccion a) => new(-a._numerador, a._denominador);

        public static Fraccion operator +(Fraccion a, Fraccion b) 
            => new(a._numerador * b._denominador + b._numerador * a._denominador, a._denominador * b._denominador);
        
        public static Fraccion operator -(Fraccion a, Fraccion b) => a + -b;
        
        public static Fraccion operator *(Fraccion a, Fraccion b)
            => new(a._numerador * b._numerador, a._denominador * b._denominador);

        public static Fraccion operator /(Fraccion a, Fraccion b)
        {
            if (b._numerador == 0)
            {
                throw new DivideByZeroException();
            }
            return new Fraccion(a._numerador * b._denominador, a._denominador * b._numerador);
        }

        public NumeroMixto ConvertToMixedFraccion()
        {
            var cociente = Numerator() / Denominator();
            var residuo = Numerator() % Denominator();
            return new NumeroMixto(cociente, new Fraccion(residuo, Denominator()));
        }
        public Fraccion Simplify()
        {
            var mcd = 2;
            var result = this;
            while (mcd > 1)
            {
                mcd = Euclides.GetMaximoComunDivisor(result.Numerator(), result.Denominator());
                result = new Fraccion(result.Numerator() / mcd, result.Denominator() / mcd);
            }
            return result;
        }

        public override string ToString() => $"{_numerador}/{_denominador}";
    }
}
