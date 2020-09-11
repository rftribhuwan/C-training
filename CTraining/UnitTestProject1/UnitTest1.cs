using System;
using Day4AbstractAddition;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var addition = new Addition();
            var a = 2;
            var result = 12;
            var actualResult = addition.AdditionFunction(a);
            Assert.AreEqual(result,actualResult);
        }
    }
}
