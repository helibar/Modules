using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryDisplay;

namespace BinaryDisplayTest
{
    //You can add more tests.
    [TestClass]
    public class UnitTestCount
    {
        [TestMethod]
        public void Binary_Count_Zero()
        {
            var bin = new Binary();

            int result = bin.Count("0");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Binary_Count_Num()
        {
            var bin = new Binary();

            int result = bin.Count("1");

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Binary_Count_More()
        {
            var bin = new Binary();

            int result = bin.Count("01110011101");

            Assert.AreEqual(7, result);
        }

     
    }
}
