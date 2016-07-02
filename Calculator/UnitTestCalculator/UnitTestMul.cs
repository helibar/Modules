using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTestMul

    {
        [TestMethod]
        public void Calc_Mul_BothPositive()
        {
            var calculator = new Calc();

            double MulResult = calculator.Mul(1.99, 2.26);

            Assert.AreEqual(4.4974, MulResult);
        }
        public void Calc_Mul_One()
        {
            var calculator = new Calc();

            double MulResult = calculator.Mul(22.88, 1);

            Assert.AreEqual(4.4974, MulResult);
        }

        [TestMethod]
        public void Calc_Mul_SingleZero()
        {
            var calculator = new Calc();

            double MulResult = calculator.Mul(1.99787886868, 0);

            Assert.AreEqual(0, MulResult);
        }

        [TestMethod]
        public void Calc_Mul_TwoZeros()
        {
            var calculator = new Calc();

            double MulResult = calculator.Mul(0.0, 0);

            Assert.AreEqual(0, MulResult);
        }

        [TestMethod]
        public void Calc_Mul_Commutative()
        {
            var calculator = new Calc();

            var first = 323.5646;
            var second = -99.99;

            Assert.AreEqual(calculator.Mul(first, second), calculator.Mul(second, first));
        }

        [TestMethod]
        public void Calc_Mul_MulSingleNegative()
        {
            var calc = new Calc();

            var result = calc.Mul(1, -1);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Calc_Mul_MulTwoNegative()
        {
            var calc = new Calc();

            var result = calc.Mul(-1, -2);

            Assert.AreEqual(2, result);
        }

    }
}
