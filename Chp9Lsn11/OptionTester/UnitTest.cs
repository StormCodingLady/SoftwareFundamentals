using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chp9Lsn11;
using UserInputHandler;

namespace OptionTester
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void StringReverse_Test()
        {
            string inputString = "54321";
            string testString = "12345";
            string isEquivalent = Program.ReverseIntegerOrder(inputString);

            Assert.IsTrue(testString == isEquivalent);
        }

        [TestMethod]
        public void NumberAverage_Test()
        {
            double[] inputArray = { 1, 2, 3, 4, 5};
            double[] testArray = { 3 };
            double[] isEquivalent = Program.CalculateAverage(inputArray);

            Assert.IsTrue(testArray[0] == isEquivalent[0]);
        }

        [TestMethod]
        public void LinearSolve_Test()
        {
            double testX = 7;
            double isEquivalent = Program.SolveLinearEquation(2, -4, 10);

            Assert.IsTrue(testX == isEquivalent);
        }
    }
}
