using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise04;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsOdd()
        {
            bool result3 = Program.IsOdd(3);
            Assert.AreEqual(true, result3);

            bool result4 = Program.IsOdd(4);
            Assert.AreEqual(false, result4);
        }

        

        [TestMethod]
        public void IsEven()
        {
            bool result1 = Program.IsEven(4);
            Assert.AreEqual(true, result1);

            bool result2 = Program.IsEven(3);
            Assert.AreEqual(false, result2);
        }
        [TestMethod]
        public void IsPrime()
        {
            bool result1 = Program.IsPrime(5);
            Assert.AreEqual(true, result1);

            bool result2 = Program.IsPrime(4);
            Assert.AreEqual(false, result2);
        }

        [TestMethod]
        public void Square()
        {
            int result1 = Program.Square(4);
            Assert.AreEqual(16, result1);

            int result2 = Program.Square(3);
            Assert.AreEqual(9, result2);
        }

        [TestMethod]
        public void Cube()
        {
            int result1 = Program.Cube(4);
            Assert.AreEqual(64, result1);

            int result2 = Program.Cube(3);
            Assert.AreEqual(27, result2);
        }
    }
}
