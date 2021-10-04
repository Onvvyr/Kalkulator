using NUnit.Framework;
using System;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Test]
        public void Add_AddsTwoPositiveNumbers_Calculated()
        {
            int sum = Calculator.Add(2, 2);
            Assert.AreEqual(4, sum);
        }
    }
}
