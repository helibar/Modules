using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTestSub
    {
        [TestMethod]
        public void Calc_Sub_BothPositive()
        {
            var calculator = new Calc();

            double SubResult = calculator.Sub(1, 1);

            Assert.AreEqual(0, SubResult);
        }

        [TestMethod]
        public void Calc_Sub_SingleZero()
        {
            var calculator = new Calc();

            double SubResult = calculator.Sub(1, 0);

            Assert.AreEqual(1, SubResult);
        }

        [TestMethod]
        public void Calc_Sub_TwoZeros()
        {
            var calculator = new Calc();

            double SubResult = calculator.Sub(0, 0);

            Assert.AreEqual(0, SubResult);
        }



        [TestMethod]
        public void Calc_Sub_Commutative_Pos()
        {
            var calculator = new Calc();

            var first = 311;
            var second = 28;

            Assert.AreEqual(calculator.Sub(first, second), -calculator.Sub(second, first));
        }


        [TestMethod]
        public void Calc_Sub_SubTwoNegative()
        {
            var calc = new Calc();

            var result = calc.Sub(-1, -1);

            Assert.AreEqual(0, result);
        }


    }
}
