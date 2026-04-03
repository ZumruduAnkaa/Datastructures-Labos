using Datastructures_ClassLibrary.Searching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_Unittesting.Searching
{
    [TestClass]
    public class BinarySearch_tests
    {
        [TestMethod]
        public void Find_ValueFound_ReturnsCorrectMidden()
        {
            int[] list = [1, 3, 5, 7, 9, 11, 13];

            Assert.AreEqual(3, Datastructures_ClassLibrary.Searching.BinarySearch.Find(list, 7));
        }

        [TestMethod]
        public void Find_ValueNotFound_ReturnsMinusOne()
        {
            int[] list = [1, 3, 5, 7, 9, 11, 13];
            Assert.AreEqual(-1, BinarySearch.Find(list, 6));
        }

        //Oefening 4
        [TestMethod]
        public void Find_StringValueFound_ReturnsCorrectIndex()
        {
            string[] list = ["ei", "aap", "jet", "wim", "gijs", "noot", "appel"];

            Assert.AreEqual(4, BinarySearch.Find(list, "gijs"));
        }


    }
}
