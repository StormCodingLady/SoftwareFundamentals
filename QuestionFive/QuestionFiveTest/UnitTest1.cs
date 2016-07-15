using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuestionFive;

namespace QuestionFiveTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ProductAnalysis_CheckOutcomes_WrittenForm()
        {
            int[] allRet = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            string[,] allWor = {
                { "Zero" },
                { "One" },
                { "Two" },
                { "Three" },
                { "Four" },
                { "Five" },
                { "Six" },
                { "Seven" },
                { "Eight" },
                { "Nine" }
            };

            int numberRowsInt = allRet.GetLength(0);
            int numberColumnsInt = allRet.GetLength(1);
            int numberRowsStr = allWor.GetLength(0);
            int numberColumnsStr = allWor.GetLength(1);
            

            for (int i = 0; i < numberRowsInt; i++)
            {
                int a = allRet[i];
                string cycle = allWor[i];
                string finAn = Program.EngRet(a);
                Assert.IsTrue(finAn == cycle);
            }
        }
    }
}
