using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Tests
{
    [TestClass]
    public class LogicTests
    {
        [TestMethod]
        public void EmptySentence()
        {
            double percentage = Logic.Count("");
            Assert.AreEqual(0, percentage);
        }

        [TestMethod]
        public void OnlyLetters()
        {
            double percentage = Logic.Count("Iloveprogramming");
            Assert.AreEqual(100, percentage);
        }

        [TestMethod]
        public void LettersAndSpaces()
        {
            double percentage = Logic.Count("I love programming");
            Assert.AreEqual(100, percentage);
        }

        [TestMethod]
        public void Count_LettersAndOtherChars_CalculatesCorrectly()
        {
            double percentage = Logic.Count("I love programming!!!");
            Assert.AreEqual(84.21052631578947, percentage);
        }

        [TestMethod]
        public void Count_MixedInput_CalculatesCorrectly()
        {
            double percentage = Logic.Count("123 abc!@#");
            Assert.AreEqual(33.33333333333333, percentage);
        }
    }
}