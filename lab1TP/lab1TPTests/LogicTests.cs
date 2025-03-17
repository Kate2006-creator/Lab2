using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab1TP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace lab1TP.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void BaseTest()
        {
            double a = 3.00;
            double b = 4.00;
            double c = 5.00;

            string otvet1 = Logic.IsTriangle(a, b, c);
            string otvet2 = Logic.IsRightTriangle(a, b, c);
            Assert.AreEqual("A triangle exists.", otvet1);
            Assert.AreEqual("The triangle has 90-angle.", otvet2);

        }

        [TestMethod()]
        public void NoTriangleTest()
        {
            double a = 3.40;
            double b = 4.95;
            double c = 15.03;

            string otvet1 = Logic.IsTriangle(a, b, c);
            Assert.AreEqual("A triangle doesn`t exist.", otvet1);

        }

        [TestMethod()]
        public void EqualSidesTest()
        {
            double a = 5.89;
            double b = 5.89;
            double c = 5.89;

            string otvet1 = Logic.IsTriangle(a, b, c);
            string otvet2 = Logic.IsRightTriangle(a, b, c);
            Assert.AreEqual("A triangle exists.", otvet1);
            Assert.AreEqual("The triangle doesn`t have 90-angle.", otvet2);

        }

        [TestMethod()]
        public void TriangleRB()
        {
            double a = 6.33;
            double b = 6.33;
            double c = 4.96;

            string otvet1 = Logic.IsTriangle(a, b, c);
            string otvet2 = Logic.IsRightTriangle(a, b, c);
            Assert.AreEqual("A triangle exists.", otvet1);
            Assert.AreEqual("The triangle doesn`t have 90-angle.", otvet2);

        }
    }
}