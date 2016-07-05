using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strings;

namespace UnitTestStrings
{
    [TestClass]
    public class UnitTestSort
    {
        StringsActions s = new StringsActions();

        [TestMethod]
        public void Test_Sort_None()
        {
            string[] w = { };
            string result = s.Sort(w);

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void Test_Sort_One()
        {
            string[] w = { "abc" };
            string result = s.Sort(w);

            Assert.AreEqual("abc ", result);
        }

        [TestMethod]
        public void Test_Sort_ContainNumbers()
        {
            string[] w = { "23", "2kj", "as2" };
            string result = s.Sort(w);

            Assert.AreEqual("23 2kj as2 ", result);
        }

        [TestMethod]
        public void Test_Sort_General()
        {
            string[] w = { "ff", "fa", "a9", "9a", "cvfsa","qaaa" };
            string result = s.Sort(w);

            Assert.AreEqual("9a a9 cvfsa fa ff qaaa ", result);
        }
    }
}
