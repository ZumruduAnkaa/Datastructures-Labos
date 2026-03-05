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
    }
}
