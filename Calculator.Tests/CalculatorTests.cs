using NUnit.Framework;
using System;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        public void Add_AddsTwoPositiveNumbers_Calculated()
        {
            var calc = new Calculator.Calculator();
            int sum = calc.CalculatorAdd(2, 2);
            Assert.AreEqual(4, sum);
        }
    }
}
