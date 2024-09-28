using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FractionExcercise
{
    public class Fraction
    {
        public int Numerator { get; set; }

        public int Denominator { get; set; }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be 0!");
            }
            Numerator = numerator;
            Denominator = denominator;
            Simplify();
        }
        
        private void Simplify()
        {
            int gcd = GCD(Math.Abs(Numerator), Math.Abs(Denominator));
            Numerator /= gcd;
            Denominator /= gcd;

            if (Denominator < 0)
            {
                Numerator = -Numerator;
                Denominator = -Denominator;

            }
        }

        private static int GCD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            return a;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            int numerator = (a.Numerator * b.Denominator) + (b.Numerator * a.Denominator);
            int denominator = (a.Denominator * b.Denominator);

            return new Fraction(numerator, denominator);
        }
        public override string ToString()
        {
            return $"{Numerator} / {Denominator}";
        }
    }
}
