using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace WinFormsApp1.Tests
{
    [TestClass()]
    public class FractionTests
    {
        
        [TestMethod]
        public void plus_fractions()
        {
            Fraction a = new Fraction(1, 3);
            Fraction b = new Fraction(1, 5);
            Fraction result = a + b;
            Assert.AreEqual(8, result.Numerator);
            Assert.AreEqual(15, result.Denominator);
        }

        [TestMethod]
        public void plus_negative_fractions()
        {
            Fraction a = new Fraction(-1, 2);
            Fraction b = new Fraction(1, 4);
            Fraction result = a + b;
            Assert.AreEqual(1, result.Numerator);
            Assert.AreEqual(-4, result.Denominator);
        }

        [TestMethod]
        public void minus_fractions()
        {
            Fraction a = new Fraction(1, 3);
            Fraction b = new Fraction(1, 5);
            Fraction result = a - b;
            Assert.AreEqual(2, result.Numerator);
            Assert.AreEqual(15, result.Denominator);
        }

        [TestMethod]
        public void minus_negative_fractions()
        {
            Fraction a = new Fraction(-1, 2);
            Fraction b = new Fraction(1, 4);
            Fraction result = a - b;
            Assert.AreEqual(3, result.Numerator);
            Assert.AreEqual(-4, result.Denominator);
        }

        [TestMethod]
        public void multiply_fractions()
        {
            Fraction a = new Fraction(1, 2);
            Fraction b = new Fraction(1, 4);
            Fraction result = a * b;
            Assert.AreEqual(1, result.Numerator);
            Assert.AreEqual(8, result.Denominator);
        }

        [TestMethod]
        public void multiply_negative_fractions()
        {
            Fraction a = new Fraction(-1, 2);
            Fraction b = new Fraction(1, 4);
            Fraction result = a * b;
            Assert.AreEqual(1, result.Numerator);
            Assert.AreEqual(-8, result.Denominator);
        }

        [TestMethod]
        public void multiply_zero_fractions()
        {
            Fraction a = new Fraction(0, 2);
            Fraction b = new Fraction(1, 4);
            Fraction result = a * b;
            Assert.AreEqual(0, result.Numerator);
            Assert.AreEqual(8, result.Denominator);
        }

        [TestMethod]
        public void divide_fractions()
        {
            Fraction a = new Fraction(1, 2);
            Fraction b = new Fraction(1, 4);
            Fraction result = a / b;
            Assert.AreEqual(2, result.Numerator);
            Assert.AreEqual(1, result.Denominator);
        }

        [TestMethod]
        public void divide_negative_fractions()
        {
            Fraction a = new Fraction(-1, 2);
            Fraction b = new Fraction(1, 4);
            Fraction result = a / b;
            Assert.AreEqual(2, result.Numerator);
            Assert.AreEqual(-1, result.Denominator);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void divide_zero_fractions()
        {
            Fraction a = new Fraction(1, 2);
            Fraction b = new Fraction(0, 4);
            Fraction result = a / b;
        }

        [TestMethod]
        public void compare_fractions1()
        {
            Fraction a = new Fraction(1, 2);
            Fraction b = new Fraction(2, 4);
            Assert.IsTrue(a == b);
        }
       
        [TestMethod]
        public void IsValidFraction1()
        {
            Fraction a = new Fraction(1, 2);
            Assert.IsTrue(a.IsValid());
        }

        [TestMethod]
        public void IsValidFraction2()
        {
            Fraction a = new Fraction(2, 1);
            Assert.IsFalse(a.IsValid());
        }

        [TestMethod]
        public void reduce_fraction()
        {
            Fraction a = new Fraction(2, 4);
            Fraction result = Fraction.Reduce(a);
            Assert.AreEqual(1, result.Numerator);
            Assert.AreEqual(2, result.Denominator);
        }

        [TestMethod]
        public void IsValidDenominator1()
        {
            Fraction a = new Fraction(1, 2);
            Assert.IsTrue(a.IsValidDenominator());
        }

        [TestMethod]
        public void IsValidDenominator2()
        {
            try
            {
                Fraction a = new Fraction(1, 0);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Знаменатель не может быть равен нулю.", e.Message);
            }
        }

        [TestMethod]
        public void IsValidDenominator3()
        {
            Fraction a = new Fraction(1, -2);
            Assert.IsTrue(a.IsValidDenominator());
        }

    }
}