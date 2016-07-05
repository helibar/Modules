using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strings;

namespace UnitTestStrings
{
    [TestClass]
    public class UnitTestRevers
    {
        StringsActions s = new StringsActions();

        [TestMethod]
        public void Test_Revers_None()
        {
            string[] w = { };
            string result = s.Revers(w);

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void Test_Revers_One()
        {
            string[] w = { "abc" };
            string result = s.Revers(w);

            Assert.AreEqual("abc ", result);
        }

        [TestMethod]
        public void Test_Revers_ContainNumbers()
        {
            string[] w = { "23", "2kj", "as2" };
            string result = s.Revers(w);

            Assert.AreEqual("as2 2kj 23 ", result);
        }

        [TestMethod]
        public void Test_Revers_ContainSings()
        {
            string[] w = { "2#3", "2.8", "!@as2", "hg3)...5", "^%$#445d~" };
            string result = s.Revers(w);

            Assert.AreEqual("^%$#445d~ hg3)...5 !@as2 2.8 2#3 ", result);
        }
    }
}
