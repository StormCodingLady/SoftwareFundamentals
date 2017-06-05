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
        public void Program_CalcSquareRootWithNegativeInput_ThrowsException()
        {
            int[] invalidNumbers = { 0, -2 };
            int numberOfColumns = invalidNumbers.Length;

            for (int i = 0; i < numberOfColumns; i++)
            {
                int testNumbers = invalidNumbers[i];
                Program.CalculateSquareRoot(testNumbers);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException), "Invalid Input! Cannot enter a number less than or equal to zero.")]
        public void UserBarrier_ConfirmsInputEqualOrLessThanZero_ThrowsException()
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
        public void UserBarrier_ConfirmsNonAcceptanceOfNonNumbers_ThrowsException()
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
        public void UserBarrier_TestsNumbersLargerThanTheMaxOrMin_ThrowsException()
        {
            string[] invalidNumbers = { "2147483648", "–2147483649" };
            int numberOfColumns = invalidNumbers.GetLength(0);

            for (int i = 0; i < numberOfColumns; i++)
            {
                string testNumbers = invalidNumbers[i];
                UserBarrier.UserInput(testNumbers);
            }
        }

        [TestMethod]
        public void Program_TestForCorrectAnswers()
        {
            int[] positiveInput = { 4, 16, 256 };
            int[] correctOutput = { 2, 4, 16 };
            int inputColumns = positiveInput.GetLength(0);
            int outputColumns = correctOutput.GetLength(0);

            for (int i = 0; i < inputColumns && i < outputColumns; i++)
            {
                int inputNumbers = positiveInput[i];
                int outputNumbers = correctOutput[i];

                double finalAnswer = Program.CalculateSquareRoot(inputNumbers);
                Assert.IsTrue(finalAnswer == outputNumbers);
            }
        }

        [TestMethod]
        public void UserBarrier_StringToIntValidity()
        {
            string[] stringInput = { "1", "2", "3" };
            int[] integerOutput = { 1, 2, 3 };
            int inputColumns = stringInput.GetLength(0);
            int outputColumns = integerOutput.GetLength(0);

            for (int i = 0; i < inputColumns && i < outputColumns; i++)
            {
                string inputString = stringInput[i];
                int outputInteger = integerOutput[i];

                int integerNumber = UserBarrier.UserInput(inputString);
                Assert.IsTrue(integerNumber == outputInteger);
            }
        }
    }
}
