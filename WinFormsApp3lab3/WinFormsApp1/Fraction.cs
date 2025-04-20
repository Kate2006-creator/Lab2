using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {

            this.numerator = numerator;
            this.denominator = denominator;
        }

        public int Numerator
        {
            get { return numerator; }
        }

        public int Denominator
        {
            get { return denominator; }
        }

        public bool IsValid()
        {
            return Numerator < Denominator;
        }
        public bool IsValidDenominator()
        {
            return Denominator != 0;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            int newNumerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            int newDenominator = a.Denominator * b.Denominator;
            return Reduce(new Fraction(newNumerator, newDenominator));
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            int newNumerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            int newDenominator = a.Denominator * b.Denominator;
            return Reduce(new Fraction(newNumerator, newDenominator));
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            int newNumerator = a.Numerator * b.Numerator;
            int newDenominator = a.Denominator * b.Denominator;
            return Reduce(new Fraction(newNumerator, newDenominator));
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {

                if (b.Numerator == 0)
                {
                    throw new DivideByZeroException("Деление на ноль!");
            }

            int newNumerator = a.Numerator * b.Denominator;
            int newDenominator = a.Denominator * b.Numerator;
            return Reduce(new Fraction(newNumerator, newDenominator));
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            return a.Numerator * b.Denominator == b.Numerator * a.Denominator;
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a == b);
        }

        public static bool operator <(Fraction a, Fraction b)
        {
            return a.Numerator * b.Denominator < b.Numerator * a.Denominator;
        }

        public static bool operator >(Fraction a, Fraction b)
        {
            return a.Numerator * b.Denominator > b.Numerator * a.Denominator;
        }


        // НОД 
        public static int GreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public static Fraction Reduce(Fraction fraction)
        {
            int gcd = GreatestCommonDivisor(fraction.Numerator, fraction.Denominator);
            return new Fraction(fraction.Numerator / gcd, fraction.Denominator / gcd);
        }
    }
}
