using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chp6Lsn3;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_ForPositives()
        {
            int[] positiveInput = { 1, 2, 3, 4, 5 };
            int[] positiveAnswer = { 1, 5 };

            int numberColumns = positiveAnswer.GetLength(0);
            for (int i = 0; i < numberColumns; i++)
            {
                int[] comparison = Program.SmallestAndLargest(positiveInput);
                Assert.IsTrue(positiveAnswer[i] == comparison[i]);
            }
        }

        [TestMethod]
        public void TestMethod_ForNegatives()
        {
            int[] negativeInput = { -5, -4, -3, -2, -1 };
            int[] negativeAnswer = { -5, -1 };

            int numberColumns = negativeAnswer.GetLength(0);
            for (int i = 0; i < numberColumns; i++)
            {
                int[] comparison = Program.SmallestAndLargest(negativeInput);
                Assert.IsTrue(negativeAnswer[i] == comparison[i]);
            }
        }
    }
}
