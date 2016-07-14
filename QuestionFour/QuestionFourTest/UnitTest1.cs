using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuestionFour;

namespace QuestionFourTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ProductAnalysis_CheckOutcomes_DescendingOrder()
        {
            double[,] descOrd = {
                { 1.2, 1.4, 1.6 },
                { 1.2, 1.6, 1.4 },
                { 1.4, 1.2, 1.6 },
                { 1.4, 1.6, 1.2 },
                { 1.6, 1.2, 1.4 },
                { 1.6, 1.4, 1.2 }
            };

            int numberRows = descOrd.GetLength(0);
            int numberColumns = descOrd.GetLength(1);

            double small = 1.2;
            double medium = 1.4;
            double large = 1.6;

            for (int i = 0; i < numberRows; i++)
            {
                double a = descOrd[i, 0];
                double b = descOrd[i, 1];
                double c = descOrd[i, 2];
                Program.NumSort(a, b, c);
                Assert.IsTrue(small == a && medium == b && large == c);
            }
        }
    }
}
