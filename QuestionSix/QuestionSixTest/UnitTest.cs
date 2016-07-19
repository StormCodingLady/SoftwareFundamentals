using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuestionSix;

namespace QuestionSixTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CheckOutcome_NumberOfSolutions()
        {
            double[,] sampleCoefficient = {
                { 5, 6, 1 }, //two solutions.
                { 5, 2, 1 }, //no solutions.
                { 1, -6, 9 } //one solution.
            };

            double numberRows = sampleCoefficient.GetLength(0);
            double numberColumns = sampleCoefficient.GetLength(1);

            for (int i = 0; i < numberColumns; i++)
            {
                double a = sampleCoefficient[i,0];
                double b = sampleCoefficient[i,1];
                double c = sampleCoefficient[i,2];
                double solutionCheck = Program.SoluEval(a, b, c);

                if (i == 0)
                {
                    Assert.IsTrue(solutionCheck == 2);
                }
                if (i == 1)
                {
                    Assert.IsTrue(solutionCheck == 0);
                }
                if (i == 2)
                {
                    Assert.IsTrue(solutionCheck == 1);
                }
            }
        }

        [TestMethod]
        public void CheckOutcomes_CorrectSolutions()
        {
            double[,] sampleCoefficient = {
                { 5, 6, 1 }, //two solutions.
                { 5, 2, 1 }, //no solutions.
                { 1, -6, 9 } //one solution.
            };

            double numberRows = sampleCoefficient.GetLength(0);
            double numberColumns = sampleCoefficient.GetLength(1);

            for (int i = 0; i < numberColumns; i++)
            {
                double a = sampleCoefficient[i, 0];
                double b = sampleCoefficient[i, 1];
                double c = sampleCoefficient[i, 2];
                Program.Coefficient solutionCheck = Program.SolveQuadratic(a, b, c);

                if (i == 0)
                {
                    Assert.IsTrue(solutionCheck.x == -0.2 && solutionCheck.y == -1);
                }
                if (i == 1)
                {
                    Assert.IsTrue(solutionCheck.w < 0);
                }
                if (i == 2)
                {
                    Assert.IsTrue(solutionCheck.z == 3);
                }
            }
        }
    }
}
