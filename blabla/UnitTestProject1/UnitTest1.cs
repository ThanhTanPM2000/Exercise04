using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using blabla;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestContain5()
        {
            int[] Arr1 = new int[] { 1, 2, 3, 4 };
            bool result5 = Program.IsContain5(Arr1);
            Assert.AreEqual(false, result5);

            int[] Arr2 = new int[] { 1, 2, 3, 4,5 };
            bool result0 = Program.IsContain5(Arr2);
            Assert.AreEqual(true, result0);
        }

        [TestMethod]
        public void TestContain5or6()
        {
            int[] Arr1 = new int[] { 1, 2, 3, 4 };
            bool result5 = Program.IsContain5or6(Arr1);
            Assert.AreEqual(false, result5);

            int[] Arr2 = new int[] { 1, 2, 3, 4, 5 };
            bool result5or6 = Program.IsContain5or6(Arr2);
            Assert.AreEqual(true, result5or6);
        }

        [TestMethod]
        public void TestContain5And6()
        {
            int[] Arr1 = new int[] { 1, 2, 3, 4 };
            bool result5 = Program.IsContain5And6(Arr1);
            Assert.AreEqual(false, result5);

            int[] Arr2 = new int[] { 1, 2, 3, 4, 5 ,6};
            bool result5and6 = Program.IsContain5And6(Arr2);
            Assert.AreEqual(true, result5and6);
        }
    }
}
