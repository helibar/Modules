using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTestAdd
    {
        [TestMethod]
        public void Calc_Add_BothPositive()
        {
            var calculator = new Calc();

            double addResult = calculator.Add(1, 1);

            Assert.AreEqual(2, addResult);
        }

        [TestMethod]
        public void Calc_Add_SingleZero()
        {
            var calculator = new Calc();

            double addResult = calculator.Add(10, 0);

            Assert.AreEqual(10, addResult);
        }

        [TestMethod]
        public void Calc_Add_TwoZeros()
        {
            var calculator = new Calc();

            double addResult = calculator.Add(0, 0);

            Assert.AreEqual(0, addResult);
        }

        [TestMethod]
        public void Calc_Add_Commutative()
        {
            var calculator = new Calc();

            var first = 42;
            var second = 777;

            Assert.AreEqual(calculator.Add(first, second), calculator.Add(second, first));
        }

        [TestMethod]
        public void Calc_Add_AddSingleNegative()
        {
            var calc = new Calc();

            var result = calc.Add(1, -1);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Calc_Add_AddTwoNegative()
        {
            var calc = new Calc();

            var result = calc.Add(-1, -1);

            Assert.AreEqual(-2, result);
        }
    }
}
