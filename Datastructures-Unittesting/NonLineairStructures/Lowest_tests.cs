using Datastructures_ClassLibrary.NonLineairStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_Unittesting.NonLineairStructures
{
    [TestClass]
    public class Lowest_tests
    {
        [TestMethod]
        public void Lowest_ReturnsLowestValue()
        {
            var bst = new BST();
            bst.Insert(5);
            bst.Insert(3);
            bst.Insert(7);
            bst.Insert(1);
            Assert.AreEqual(1, bst.Lowest());
        }
    }
}
