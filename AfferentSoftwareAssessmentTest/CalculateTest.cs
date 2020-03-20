using AlgebraStringSolve;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgebraStringSolve.Tests
{
    [TestClass()]
    public class CalculateTest
    {
        [TestMethod()]
        public void Calculation_AllowedExpression_ReturnsResult()
        {
            var calculate = new Calculate();

            var result = calculate.Calculation("2 + 3 * (4 - 1) / 2.2");

            Assert.AreEqual("6,09", result);
        }

        [TestMethod()]
        public void Calculation_AllowedExpression1_ReturnsResult()
        {
            var calculate = new Calculate();

            var result = calculate.Calculation("9.4 * 8 / 4");

            Assert.AreEqual("18,8", result);
        }

        [TestMethod()]
        public void Calculation_AllowedExpression2_ReturnsResult()
        {
            var calculate = new Calculate();

            var result = calculate.Calculation("9-4 * 8 / 4");

            Assert.AreEqual("1", result);
        }

        [TestMethod()]
        public void Calculation_AllowedExpression3_ReturnsResult()
        {
            var calculate = new Calculate();

            var result = calculate.Calculation("(3*3) + 5 -2*3");

            Assert.AreEqual("8", result);
        }

        [TestMethod()]
        public void Calculation_IllegalExpression_ReturnsError()
        {
            var calculate = new Calculate();

            var result = calculate.Calculation("(3*3) +' 5 -2*3"); //Illegal ' in string

            Assert.AreEqual("Illegal character used in expression.", result);
        }

        [TestMethod()]
        public void Calculation_IllegalExpression2_ReturnsError()
        {
            var calculate = new Calculate();

            var result = calculate.Calculation("abc"); //letters in string

            Assert.AreEqual("Illegal character used in expression.", result);
        }
    }
}
