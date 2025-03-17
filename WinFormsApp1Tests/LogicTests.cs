using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Tests
{
    [TestClass]
    public class LogicTests
    {
        [TestMethod]
        public void IsTriangleBasic()
        {
            string result1 = Logic.IsTriangle(3.00, 4.00, 5.00);
            string result2 = Logic.IsRightTriangle(3.00, 4.00, 5.00);
            Assert.AreEqual("A triangle exists.", result1);
            Assert.AreEqual("The triangle has 90-angle.", result2);
        }

        [TestMethod]
        public void NoTriangle()
        {
            string result1 = Logic.IsTriangle(1.00, 2.00, 5.00);
            string result2 = Logic.IsRightTriangle(1.00, 2.00, 5.00);
            Assert.AreEqual("A triangle doesn`t exist.", result1);
            Assert.AreEqual("The triangle doesn`t have 90-angle.", result2);
        }


        [TestMethod]
        public void EqualTriangle()
        {
            string result1 = Logic.IsTriangle(59.89, 59.89, 59.89);
            string result2 = Logic.IsRightTriangle(59.89, 59.89, 59.89);
            Assert.AreEqual("A triangle exists.", result1);
            Assert.AreEqual("The triangle doesn`t have 90-angle.", result2);
        }

        [TestMethod]
        public void DoubleDiffetentValues()
        {
            string result1 = Logic.IsTriangle(3.00, 4.00, 5.00009);
            string result2 = Logic.IsRightTriangle(3.00, 4.00, 5.00009);
            Assert.AreEqual("A triangle exists.", result1);
            Assert.AreEqual("The triangle doesn`t have 90-angle.", result2);
        }
    }
}