using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strings;

namespace UnitTestStrings
{
    [TestClass]
    public class UnitTestWordsNum
    {
        StringsActions s = new StringsActions();

        [TestMethod]
        public void Test_WordsNum_None()
        {
            string[] w = { }; 
            int result = s.WordsNum(w);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test_WordsNum_One()
        {
            string[] w = {"abc"};
            int result = s.WordsNum(w);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test_WordsNum_ContainNumbers()
        {
            string[] w = { "23","2kj","as2","hg3" };
            int result = s.WordsNum(w);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Test_WordsNum_ContainSings()
        {
            string[] w = { "2#3", "2.8", "!@as2", "hg3)...5","^%$#445d~" };
            int result = s.WordsNum(w);

            Assert.AreEqual(5, result);
        }
    }
}
