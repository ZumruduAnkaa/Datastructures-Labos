using Datastructures_ClassLibrary.Searching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_Unittesting.Searching
{
    [TestClass]
    public class Hashtable_v2_tests
    {
        [TestMethod]
        public void AddItem_FindItem_ReturnsCorrectIndex()
        {
            Hashtable_v2 hashtable = new Datastructures_ClassLibrary.Searching.Hashtable_v2(3);
            hashtable.AddItem("appel");

            int result = hashtable.FindItem("appel");

            Assert.AreNotEqual(-1, result);
        }

        [TestMethod]
        public void AddItem_Collision_BothItemsFound()
        {
            Hashtable_v2 hashtable = new Datastructures_ClassLibrary.Searching.Hashtable_v2(1);
            hashtable.AddItem("appel");
            hashtable.AddItem("banaan");


            int result = hashtable.FindItem("appel");
            int result2 = hashtable.FindItem("banaan");

            Assert.AreNotEqual(-1, result);
            Assert.AreNotEqual(-1, result2);

        }
    }
}
