using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chp7Lsn2;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_ArrayEqual_IsTrue()
        {
            int[][] jaggedArray = {
                new int[] { 1, 2, 3 },
                new int[] { 1, 2, 3 }
            };

            bool isTrue = Program.EquivalentCheck(jaggedArray);
            Assert.IsTrue(isTrue);
        }

        [TestMethod]
        public void TestMethod_ArrayEqual_IsFalse_EqualIndex()
        {
            int[][] jaggedArray = {
                new int[] { 1, 2, 3 },
                new int[] { 1, 2, 6 }
            };

            bool isTrue = Program.EquivalentCheck(jaggedArray);
            Assert.IsTrue(!isTrue);
        }

        [TestMethod]
        public void TestMethod_ArrayEqual_IsFalse_UnequalIndex()
        {
            int[][] jaggedArray = {
                new int[] { 1, 2, 3 },
                new int[] { 1, 2, 3, 4 }
            };

            bool isTrue = Program.EquivalentCheck(jaggedArray);
            Assert.IsTrue(!isTrue);
        }
    }
}
