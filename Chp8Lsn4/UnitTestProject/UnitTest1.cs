using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chp8Lsn4;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] officialBinary = { 1, 0, 0, 1, 0, 1, 0, 0 };
            int[] testBinary = Program.DecimalToBinary(148);
            int numColumns = officialBinary.GetLength(0);

            for(int i = 0; i < numColumns; i++)
            {
                Assert.IsTrue(officialBinary[i] == testBinary[i]);
            }
        }
    }
}
