using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quad;

namespace QuardUnitTest
{
    [TestClass]
    public class UnitTestQuard
    {
        [TestMethod]
        public void Calc_NoSolution()
        {
            var calculator = new Calc();

            string addResult = calculator.calcQuard(3.5, 2.5, 1);

            Assert.AreEqual("No solutions", addResult);
        }


        [TestMethod]
        public void Calc_AZero()
        {
            var calculator = new Calc();
            string result = calculator.calcQuard(0, 1, 2);

            Assert.AreEqual("a cannot be zero!",result);
        }

        [TestMethod]
        public void Calc_BCZero()
        {
            var calculator = new Calc();
            string result = calculator.calcQuard(1, 0, 0);

            Assert.AreEqual("One solution: x=0", result);
        }

        [TestMethod]
        public void Calc_OneSolution()
        {
            var calculator = new Calc();

            string result = calculator.calcQuard(2, 4, 2);

            Assert.AreEqual("One solution: x=-1", result);
        }

        [TestMethod]
        public void Calc_TwoSolution()
        {
            var calculator = new Calc();

            string result = calculator.calcQuard(6, 11, -35);

            Assert.AreEqual("Two solutions: x1=1.66666666666667 x2 = -3.5", result);
        }


    } 
}
