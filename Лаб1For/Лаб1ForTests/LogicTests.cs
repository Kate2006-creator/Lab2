using Microsoft.VisualStudio.TestTools.UnitTesting;
using Лаб1For;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб1For.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod]
        public void Correct()
        {
            List<int> grades = new List<int> { 5, 4, 3, 2, 5, 4, 5 };
            string expected = "\nNumber of fives: 3 \nNumber of fours: 2 \nNumber of threes: 1 \nNumber of twos: 1";
            string actual = Logic.AnalyzeGrades(grades);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Equal()
        {
            List<int> grades = new List<int> { 3, 3, 3, 3, 3, 3, 3 };
            string expected = "\nNumber of fives: 0 \nNumber of fours: 0 \nNumber of threes: 7 \nNumber of twos: 0";
            string actual = Logic.AnalyzeGrades(grades);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Empty()
        { 
            List<int> grades = new List<int>();
            string expected = "\nNumber of fives: 0 \nNumber of fours: 0 \nNumber of threes: 0 \nNumber of twos: 0";
            string actual = Logic.AnalyzeGrades(grades);
            Assert.AreEqual(expected, actual);
        }
    }
}