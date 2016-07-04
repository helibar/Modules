using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryDisplay;

namespace BinaryDisplayTest
{
    [TestClass]
    public class UnitTestBin
    {
        [TestMethod]
        public void Binary_Bin_Zero()
        {
            var bin = new Binary();

            string result = bin.Bin(00000);

            Assert.AreEqual("0", result);
        }

        [TestMethod]
        public void Binary_Bin_Num()
        {
            var bin = new Binary();

            string result = bin.Bin(123);

            Assert.AreEqual("1111011", result);
        }

        [TestMethod]
        public void Binary_Count_MaxValue()
        {
            var bin = new Binary();

            string result = bin.Bin(Int32.MaxValue);

            Assert.AreEqual("1111111111111111111111111111111", result);
        }

    }


}
