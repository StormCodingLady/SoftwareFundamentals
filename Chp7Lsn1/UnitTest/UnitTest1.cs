using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chp7Lsn1;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_MultipleOfFive()
        {
            int[] correctAns = { 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95 };
            int[] arrayEmpty = new int[20];

            int numColumns = correctAns.GetLength(0);

            for (int i = 0; i < numColumns; i++)
            {
                int[] arrayFull = Program.FillArray(arrayEmpty);
                Assert.IsTrue(correctAns[i] == arrayFull[i]);
            }
        }
    }
}
