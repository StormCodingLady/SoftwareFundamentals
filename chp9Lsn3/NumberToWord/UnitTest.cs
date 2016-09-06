using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chp9Lsn3;

namespace NumberToWord
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod_CaptureLastDigit()
        {
            int testValue = NumberConversion.CaptureLastDigit(123);

            Assert.IsTrue(testValue == 3);
        }

        [TestMethod]
        public void TestMethod_NameOfDigit()
        {
            string testWord = NumberConversion.NameOfDigit(7);

            Assert.IsTrue(testWord == "Seven");
        }
    }
}
