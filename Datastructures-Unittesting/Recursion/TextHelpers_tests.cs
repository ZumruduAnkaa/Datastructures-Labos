using Datastructures_ClassLibrary.Recursion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_Unittesting.Recursion
{
    [TestClass]
    public class TextHelpers_tests
    {
        [TestMethod]
        public void CalculateWordLength()
        {
            Assert.AreEqual(5, TextHelpers.CalculateWordLength("hallo"));
        }

        [TestMethod]
        public void ReverseText()
        {
            Assert.AreEqual("geel", TextHelpers.ReverseText("leeg"));
        }
        [TestMethod]
        public void ReverseText_Leeg()
        {
            Assert.AreEqual("", TextHelpers.ReverseText(""));
        }
    }
}
