using Datastructures_ClassLibrary.NonLineairStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_Unittesting.NonLineairStructures
{
    [TestClass]
    public class Count_tests
    {
        [TestMethod]
        public void Count_EmptyTree_Returns0()
        {
            var bst = new BST();
            Assert.AreEqual(0, bst.Count());
        }

        [TestMethod]
        public void Count_ThreeNodes_Returns3()
        {
            var bst = new BST();
            bst.Insert(5);
            bst.Insert(3);
            bst.Insert(7);
            Assert.AreEqual(3, bst.Count());
        }
    }
}
