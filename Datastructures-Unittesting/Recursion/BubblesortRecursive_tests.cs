using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_Unittesting.Recursion
{
    [TestClass]
    public class BubblesortRecursive_tests
    {
        [TestMethod]
        public void BubblesortRecursive_SortsArrayInAscendingOrder()
        {
            int[] input = [5, 2, 9, 1, 5, 6];
            int[] expected = [1, 2, 5, 5, 6, 9];

            Datastructures_ClassLibrary.Recursion.BubbleSort.SortRecursive(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void BubblesortRecursive_HandlesEmptyArray()
        {
            int[] input = [];
            int[] expected = [];

            Datastructures_ClassLibrary.Recursion.BubbleSort.SortRecursive(input);

            Assert.AreEqual(0, input.Length);
        }

        [TestMethod]
        public void BubblesortRecursive_HandlesSingleElementArray()
        {
            int[] input = [42];
            int[] expected = [42];

            Datastructures_ClassLibrary.Recursion.BubbleSort.SortRecursive(input);

            CollectionAssert.AreEqual(expected, input);
        }
    }
}
