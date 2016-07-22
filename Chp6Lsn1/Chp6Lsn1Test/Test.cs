using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chp6Lsn1;

namespace Chp6Lsn1Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] forFifteen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            int[] N = Program.CalcSequence(15);

            for (int i = 0; i < 15; i++)
            {
                Assert.IsTrue(N[i] == forFifteen[i]);
            }
        }
    }
}
