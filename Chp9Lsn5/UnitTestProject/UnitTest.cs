using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chp9Lsn5;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod_IsItLarger_SansOutsideCase()
        {
            int[] randomArray = { 2, 5, 2, 3, 4, 2, 8, 9, 7, 9 };
            bool[] answer = { true, false, false, true, false, false, true, false };

            for (int i = 1; i < 9; i++)
            {
                bool higherValue = Program.IsLargerThan(randomArray, i);
                Assert.IsTrue(higherValue == answer[i - 1]);
            }
        }

        [TestMethod]
        public void TestMethod_IsItLarger_OutsideCase()
        {
            int[] randomArray = { 2, 5, 2, 3, 4, 2, 8, 9, 7, 9 };
            bool[] answer = { false, true };

            for (int i = 0; i < 10; i = i + 9)
            {
                int index = i;
                if (i == 9)
                {
                    index = 1;
                }

                bool higherValue = Program.OutsideCase(randomArray, i);
                Assert.IsTrue(higherValue == answer[index]);
            }
        }
    }
}
