using Datastructures_ClassLibrary.Helpers;
using Datastructures_ClassLibrary.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_Unittesting.Sorting
{
    [TestClass]
    public class Bubblesort_tests
    {
        [TestMethod]
        public void Bubblesort_SortsArrayInAscendingOrder()
        {
            // Arrange
            int[] input = [5, 2, 9, 1, 5, 6];
            int[] expected = [1, 2, 5, 5, 6, 9];

            // Act
            Bubblesort.SortAdaptive(input);

            // Assert
            for (int i = 0; i < input.Length; i++)
            {
                Assert.AreEqual(expected[i], input[i]);
            }
            //or use this easier solution to compare both arrays
            //CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void Bubblesort_SortsLargeArrayInAscendingOrder()
        {
            // Arrange
            int[] input = RandomArrayGenerator.Generate(100000, 1, 100000, false);

            // Act
            Bubblesort.SortAdaptive(input);

            // Assert
            for (int i = 0; i < input.Length - 1; i++)
            {
                Assert.IsTrue(input[i] <= input[i + 1]);
            }
        }

        [TestMethod]
        public void Bubblesort_HandlesEmptyArray()
        {
            // Arrange
            int[] input = [];
            int[] expected = [];

            // TODO: put here your test code
            Bubblesort.SortAdaptive(input);

            Assert.AreEqual(0, input.Length);
        }

        [TestMethod]
        public void Bubblesort_HandlesSingleElementArray()
        {
            // Arrange
            int[] input = [42];
            int[] expected = [42];

            Bubblesort.SortAdaptive(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void Bubblesort_HandlesAlreadySortedArray()
        {
            int[] input = [1, 2, 3, 4, 7, 9];
            int[] expected = [1, 2, 3, 4, 7, 9];

            Bubblesort.SortAdaptive(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void Bubblesort_HandlesReverseSortedArray()
        {
            int[] input = [9, 7, 4, 3, 2, 1];
            int[] expected = [1, 2, 3, 4, 7, 9];

            Bubblesort.SortAdaptive(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void Bubblesort_HandlesArrayWithDuplicates()
        {
            int[] input = [9, 2, 8, 5, 6, 2, 8, 1];
            int[] expected = [1, 2, 2, 5, 6, 8, 8, 9];

            Bubblesort.SortAdaptive(input);

            CollectionAssert.AreEqual(expected, input);
        }
    }
}
