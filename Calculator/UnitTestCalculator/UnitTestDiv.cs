using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTestDiv
    {
        [TestMethod]
        public void Calc_Div_BothPositive()
        {
            var calculator = new Calc();

            double DivResult = calculator.Div(2.5, 1.6);

            Assert.AreEqual(1.5625, DivResult);
        }

        [TestMethod]
        public void Calc_Div_One()
        {
            var calculator = new Calc();

            double DivResult = calculator.Div(22.88, 1);

            Assert.AreEqual(22.88, DivResult);
        }

        [TestMethod]
        public void Calc_Div_DivideByZero()
        {
            var calculator = new Calc();

            double DivResult = calculator.Div(1.75764546, 0);
            bool overflowed = double.IsInfinity(DivResult);
            Assert.AreEqual(overflowed, true);
        }

        [TestMethod]
        public void Calc_Div_Zero()
        {
            var calculator = new Calc();

            double DivResult = calculator.Div(0, -3);

            Assert.AreEqual(0, DivResult);
        }

        [TestMethod]
        public void Calc_Div_TwoZeros()
        {
            var calculator = new Calc();

            double DivResult = calculator.Div(0.0, 0.000);
            bool overflowed = double.IsNaN(DivResult);

            Assert.AreEqual(overflowed, true);
        }


        [TestMethod]
        public void Calc_Div_DivSingleNegative()
        {
            var calc = new Calc();

            var result = calc.Div(1, -1);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Calc_Div_DivNegPos()
        {
            var calc = new Calc();

            var result = calc.Div(-3, 2.5);

            Assert.AreEqual(-1.2, result);
        }

        [TestMethod]
        public void Calc_Div_DivTwoNegative()
        {
            var calc = new Calc();

            var result = calc.Div(-1, -2);

            Assert.AreEqual(0.5, result);
        }
    }
}
