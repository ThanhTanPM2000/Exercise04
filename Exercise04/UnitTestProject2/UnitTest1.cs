﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise04;


namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOdd()
        {
            bool result2 = Program.IsOdd(2);
            Assert.AreEqual(false, result2);

            bool result5 = Program.IsOdd(5);
            Assert.AreEqual(true, result5);
        }

        [TestMethod]
        public void TestEven()
        {
            bool result2 = Program.IsEven(2);
            Assert.AreEqual(true, result2);

            bool result5 = Program.IsEven(5);
            Assert.AreEqual(false, result5);
        }

        [TestMethod]
        public void TestPrime()
        {
            bool result3 = Program.IsPrime(13);
            Assert.AreEqual(true, result3);
            bool result4 = Program.IsPrime(4);
            Assert.AreEqual(false, result4);
        }

        [TestMethod]
        public void Square()
        {
            int result2 = Program.Square(5);
            Assert.AreEqual(25, result2);

            int result8 = Program.Square(8);
            Assert.AreEqual(64, result8);
        }

        [TestMethod]
        public void Cube()
        {
            int result2 = Program.Cube(2);
            Assert.AreEqual(8, result2);

            int result8 = Program.Cube(3);
            Assert.AreEqual(27, result8);
        }


        [TestMethod]
        public void pow()
        {
            int result2 = Program.pow(2, 3);
            Assert.AreEqual(8, result2);

            int result3 = Program.pow(3, 0);
            Assert.AreEqual(1, result3);

            int resultAm7 = Program.pow(2, -7);
            Assert.AreEqual(0, resultAm7);
        }
        [TestMethod]
        public void Abs()
        {
            int resultAm2 = Program.Abs(-2);
            Assert.AreEqual(2, resultAm2);

            int result3 = Program.Abs(3);
            Assert.AreEqual(3, result3);

            int result0 = Program.Abs(0);
            Assert.AreEqual(0, result0);
        }
        [TestMethod]
        public void Ceil()
        {
            int resultAm0_95 = Program.Ceil(-0.95f);
            Assert.AreEqual(0, resultAm0_95);

            int result7_004 = Program.Ceil(7.004f);
            Assert.AreEqual(8, result7_004);

            int resultam4 = Program.Ceil(-4);
            Assert.AreEqual(-4, resultam4);
        }
        [TestMethod]    
        public void Floor()
        {
            int resultAm0_95 = Program.Floor(-0.95f);
            Assert.AreEqual(-1, resultAm0_95);

            int result7_004 = Program.Floor(7.004f);
            Assert.AreEqual(7, result7_004);

            int resultam4 = Program.Floor(-4);
            Assert.AreEqual(-4, resultam4);
        }

        [TestMethod]
        public void Factorial()
        {
            long result2 = Program.Factorial(2);
            Assert.AreEqual(2, result2);

            long result3 = Program.Factorial(3);
            Assert.AreEqual(6, result3);

            long result0 = Program.Factorial(0);
            Assert.AreEqual(1, result0);
        }

        [TestMethod] 
        public void TestToanCaoCap()
        {
            double result2 = Program.ToanCaoCap(2);
            Assert.AreEqual(14/15,result2);

            double result3 = Program.ToanCaoCap(3);
            Assert.AreEqual(286 / 315, result3);
        }
    }
}
