using NUnit.Framework;
using System;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Test]
        public void Add_AddTwoPositiveNumbers_Calculated()
        {
            int sum = Calculator.Add(2, 2);
            Assert.AreEqual(4, sum);
        }
        [Test]
        public void Substract_SubstractTwoPositiveNumbers_Calculated()
        {
            int sub = Calculator.Substract(4, 2);
            Assert.AreEqual(2, sub);
        }
        [Test]
        public void Multiply_MultiplyTwoPositiveNumbers_Calculated()
        {
            int Multi = Calculator.Multiply(2, 2);
            Assert.AreEqual(4, Multi);
        }
        [TestCase]
        public void Divide_ReturnsProperValue()
        {
            var calc = new Calculator();
            var div = calc.Divide(4, 2);
            Assert.AreEqual(2, div);
        }
        [Test]
        public void Divide_DivisionByZero_ThrowsException()
        {
            var calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Divide(2, 0));
        }
        [TestCase]
        public void Power_ReturnsProperValue()
        {
            var calc = new Calculator();
            var pow = calc.Power(4, 2);
            Assert.AreEqual(16, pow);
        }
    }
}
