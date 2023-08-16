using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(100, 0)]
        [DataRow(10, -1)]
        [DataRow(0, 0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            Assert.AreEqual(num1 + num2, SimpleMath.Add(num1, num2));
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            Assert.AreEqual(num1 * num2, SimpleMath.Multiply(num1, num2));
        }

        [TestMethod]
        [DataRow(5, 0)]
        [DataRow(-10, 0)]
        public void Divide_DenominatorZero_ThrowsArgumentException(double num1, double num2)
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => SimpleMath.Divide(num1, num2));
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        public void Divide_TwoValidNumbers_ReturnsCorrectQuotient(double num1, double num2)
        {
            Assert.AreEqual(num1 / num2, SimpleMath.Divide(num1, num2));
        }

        [TestMethod]
        [DataRow(10, 5)]
        [DataRow(100, 0)]
        [DataRow(10, -1)]
        [DataRow(0, 0)]
        public void Subtract_TwoValidNumbers_ReturnsCorrectResult(double num1, double num2)
        {
            Assert.AreEqual(num1 - num2, SimpleMath.Subtract(num1, num2));
        }
    }
}