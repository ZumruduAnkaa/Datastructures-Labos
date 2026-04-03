using Datastructures_ClassLibrary.Searching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_Unittesting.Searching
{
    [TestClass]
    public class LineairSearch_tests
    {
        [TestMethod]
        public void Find_ValueFound_ReturnsCorrectIndex()
        {
            int[] list = [3, 7, 1, 9, 5];
            Assert.AreEqual(3, LineairSearch.Find(list, 9));
        }

        [TestMethod]
        public void Find_ValueNotFound_ReturnsMinusOne()
        {
            int[] list = [3, 7, 1, 9, 5];
            Assert.AreEqual(-1, LineairSearch.Find(list, 15));
        }

        //Oefening 2
        [TestMethod]
        public void Find_ValueFound_ReturnsCorrectNode()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("appel");
            list.AddLast("banaan");
            list.AddLast("kers");

            var result = LineairSearch.Find(list, "banaan");

            Assert.AreEqual("banaan", result.Value);
        }

        [TestMethod]
        public void Find_ValueNotFound_ReturnsNull()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("appel");
            list.AddLast("banaan");
            list.AddLast("kers");

            var result = LineairSearch.Find(list, "fruit");

            Assert.IsNull(result);
        }

        [TestMethod]
        public void Find_ValueTwoTimesFound_ReturnsCorrectNode()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("appel");
            list.AddLast("banaan");
            list.AddLast("banaan");
            list.AddLast("kers");

            var result = LineairSearch.Find(list, "banaan", 2);

            Assert.AreEqual("banaan", result.Value);
            Assert.AreEqual("kers", result.Next.Value);
        }
    }
}
