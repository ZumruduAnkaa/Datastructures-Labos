using Datastructures_ClassLibrary.Recursion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_Unittesting.Recursion
{
    [TestClass]
    public class MathHelpers_tests
    {
        [TestMethod]
        public void CalculateNumberOfDigits_SingleDigit_Returns1()
        {
            Assert.AreEqual(1, MathHelpers.CalculateNumberOfDigits(5));
        }

        [TestMethod]
        public void CalculateNumberOfDigits_TwoDigits_Returns2()
        {
            Assert.AreEqual(2, MathHelpers.CalculateNumberOfDigits(17));
        }

        [TestMethod]
        public void CalculateNumberOfDigits_ThreeDigits_Returns3()
        {
            Assert.AreEqual(3, MathHelpers.CalculateNumberOfDigits(187));
        }

        [TestMethod]
        public void CalculateNumberOfDigits_Zero_Returns1()
        {
            Assert.AreEqual(1, MathHelpers.CalculateNumberOfDigits(0));
        }

        [TestMethod]
        public void CalculateNumberOfDigits_NegativeNumber_Returns3()
        {
            Assert.AreEqual(3, MathHelpers.CalculateNumberOfDigits(-123));
        }

        [TestMethod]
        public void CalculateFactorial_Positive()
        {
            Assert.AreEqual(720, MathHelpers.CalculateFactorial(6));
        }
        [TestMethod]
        public void CalculateFactorial_Zero_Returns1()
        {
            Assert.AreEqual(1, MathHelpers.CalculateFactorial(0));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateFactorial_NegativeNumber_ThrowsException()
        {
            MathHelpers.CalculateFactorial(-1);
        }


        [TestMethod]
        public void FibonacciNr_Zero_Returns0()
        {
            Assert.AreEqual((uint)0, MathHelpers.FibonacciNr(0));
        }

        [TestMethod]
        public void FibonacciNr_One_Returns1()
        {
            Assert.AreEqual((uint)1, MathHelpers.FibonacciNr(1));
        }

        [TestMethod]
        public void FibonacciNr_Six_Returns8()
        {
            Assert.AreEqual((uint)8, MathHelpers.FibonacciNr(6));
        }

        [TestMethod]
        public void FibonacciNr_Seven_Returns13()
        {
            Assert.AreEqual((uint)13, MathHelpers.FibonacciNr(7));
        }


        [TestMethod]
        public void FibonacciSerie_One_Returns0()
        {
            Assert.AreEqual("0", MathHelpers.FibonacciSerie(1));
        }

        [TestMethod]
        public void FibonacciSerie_Three_Returns011()
        {
            Assert.AreEqual("0 1 1", MathHelpers.FibonacciSerie(3));
        }

        [TestMethod]
        public void FibonacciSerie_Five_Returns01123()
        {
            Assert.AreEqual("0 1 1 2 3", MathHelpers.FibonacciSerie(5));
        }
    }
}
