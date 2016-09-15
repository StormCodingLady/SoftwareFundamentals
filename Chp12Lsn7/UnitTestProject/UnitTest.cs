using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chp12Lsn7;
using UserCommunication;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException), "Invalid Input! Cannot enter a number less than or equal to zero.")]
        public void SqrtTest()
        {
            int[] invalidNumbers = { 0, -2 };
            int numberOfColumns = invalidNumbers.GetLength(0);

            for (int i = 0; i < numberOfColumns; i++)
            {
                int testNumbers = invalidNumbers[i];
                Program.CalculateSquareRoot(testNumbers);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException), "Invalid Input! Cannot enter a number less than or equal to zero.")]
        public void UserInputTestArgument()
        {
            string[] invalidNumbers = { "0", "-2" };
            int numberOfColumns = invalidNumbers.GetLength(0);

            for (int i = 0; i < numberOfColumns; i++)
            {
                string testNumbers = invalidNumbers[i];
                UserBarrier.UserInput(testNumbers);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(System.FormatException))]
        public void UserInputTestFormat()
        {
            string[] invalidNumbers = { "a", "apple" };
            int numberOfColumns = invalidNumbers.GetLength(0);

            for (int i = 0; i < numberOfColumns; i++)
            {
                string testNumbers = invalidNumbers[i];
                UserBarrier.UserInput(testNumbers);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(System.OverflowException))]
        public void UserInputTestOverflow()
        {
            string[] invalidNumbers = { "2147483648", "–2147483649" };
            int numberOfColumns = invalidNumbers.GetLength(0);

            for (int i = 0; i < numberOfColumns; i++)
            {
                string testNumbers = invalidNumbers[i];
                UserBarrier.UserInput(testNumbers);
            }
        }
    }
}
