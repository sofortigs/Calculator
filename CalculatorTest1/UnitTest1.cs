using System;
using NUnit.Framework;
using Calculator;


namespace calculatorTest
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(1, 3, 4)]
        [TestCase(-2, -6, -8)]
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 2)]
        [TestCase(-94, -32, -126)]
        public void TestSumMethod(double number1, double number2, double expRes)
        {
            double actRes = new Calculation().Sum(number1, number2);
            Assert.AreEqual(expRes, actRes);
        }

        [TestCase(10, 2, 5)]
        [TestCase(10, -2, -5)]
        [TestCase(-5, -5, 1)]
        [TestCase(-15, -3, 5)]
        [TestCase(-64, -32, 2)]
        public void TestDivisionMethod(double number1, double number2, double expRes)
        {
            double actRes = new Calculation().Division(number1, number2);
            Assert.AreEqual(expRes, actRes);
        }

        [TestCase(6, 2, 12)]
        [TestCase(42, 6, 252)]
        [TestCase(10, 30, 300)]
        [TestCase(-92, 6, -552)]
        [TestCase(-46, -6, 276)]
        public void TestMultiply(double number1, double number2, double expRes)
        {
            double actRes = new Calculation().Multiply(number1, number2);
            Assert.AreEqual(expRes, actRes);
        }

        [TestCase(20, 5, 15)]
        [TestCase(667, 80, 587)]
        [TestCase(100, 80, 20)]
        [TestCase(-20, -6, -14)]
        [TestCase(-36, 10, -46)]

        public void TestDiff(double number1, double number2, double expRes)
        {
            double actRes = new Calculation().Diff(number1, number2);
            Assert.AreEqual(expRes, actRes);
        }
        }
    }