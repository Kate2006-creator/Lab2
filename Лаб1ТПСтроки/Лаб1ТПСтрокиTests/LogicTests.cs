using Microsoft.VisualStudio.TestTools.UnitTesting;
using Лаб1ТПСтроки;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб1ТПСтроки.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod]
        public void BaseTest()
        {
            string sentence = "Hello, World!";
            double expectedPercentage = 83.33;   
            double actualPercentage = Logic.Count(sentence);
            Assert.AreEqual(expectedPercentage, Math.Round(actualPercentage, 2)); // Округляем до 2 знаков
        }

        [TestMethod]
        public void Empty()
        {
            string sentence = "";
            double expectedPercentage = 0;
            double actualPercentage = Logic.Count(sentence);
            Assert.AreEqual(expectedPercentage, actualPercentage);
        }

        [TestMethod]
        public void OnlySigns()
        {
            string sentence = "123!@#$";
            double expectedPercentage = 0;
            double actualPercentage = Logic.Count(sentence);
            Assert.AreEqual(expectedPercentage, actualPercentage);
        }

        [TestMethod]
        public void OnlySpaces()
        {
            string sentence = "   ";
            double expectedPercentage = 0;
            double actualPercentage = Logic.Count(sentence);
            Assert.AreEqual(expectedPercentage, actualPercentage);
        }

        [TestMethod]
        public void LettersAndSigns()
        {
            string sentence = "I love programming!!))";
            double expectedPercentage = 80.00;  
            double actualPercentage = Logic.Count(sentence);
            Assert.AreEqual(expectedPercentage, Math.Round(actualPercentage, 2)); 
        }
    }
}