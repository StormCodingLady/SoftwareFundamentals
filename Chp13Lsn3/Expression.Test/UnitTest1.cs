using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chp13Lsn3;

namespace Chp13Lsn3Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckParensTest()
        {
            Expression Expression = new Expression();
            string[] expressArrayFalse = new string[] { "(1+2)(5+q(", "((", ")(" };
            string[] expressArrayTrue = new string[] { "(1+2)(5+q)", "()", "( 999 )()" };

            foreach (string expression in expressArrayFalse)
            {
                bool isItTrue = Expression.CheckParens(expression);
                Assert.IsFalse(isItTrue);
            }

            foreach (string expression in expressArrayTrue)
            {
                bool isItTrue = Expression.CheckParens(expression);
                Assert.IsTrue(isItTrue);
            }
        }
    }
}
