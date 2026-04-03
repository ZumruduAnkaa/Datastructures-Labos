using Datastructures_ClassLibrary.Searching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_Unittesting.Searching
{
    [TestClass]
    public class Hashtable_tests
    {
        [TestMethod]
        public void AddItem_FindItem_ReturnsCorrectIndex()
        {
            Hashtable hashtable = new Datastructures_ClassLibrary.Searching.Hashtable(10);
            hashtable.AddItem("appel");

            int result = hashtable.FindItem("appel");

            Assert.AreNotEqual(-1, result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddItem_Collision_ThrowsException()
        {
            Hashtable hashtable = new Datastructures_ClassLibrary.Searching.Hashtable(1);

            hashtable.AddItem("appel");
            hashtable.AddItem("banaan");
        }
    }
}
