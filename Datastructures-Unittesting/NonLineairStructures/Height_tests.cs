using Datastructures_ClassLibrary.NonLineairStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_Unittesting.NonLineairStructures
{
    [TestClass]
    public class Height_tests
    {
        [TestMethod]
        public void Height_ReturnsCorrectHeight()
        {
            var bst = new BST();
            bst.Insert(5);
            bst.Insert(3);
            bst.Insert(7);
            bst.Insert(1);
            Assert.AreEqual(3, bst.Height());
        }
    }
}
