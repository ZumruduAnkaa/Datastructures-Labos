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
    public class Insertionsort_tests
    {
        [TestMethod]
        public void Selectionsort_SortsArrayInAscendingOrder()
        {
            // Arrange
            int[] input = [5, 2, 9, 1, 5, 6];
            int[] expected = [9, 6, 5, 5, 2, 1];

            // Act
            Insertionsort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void Selectionsort_SortsLargeArrayInAscendingOrder()
        {
            // Arrange
            int[] input = RandomArrayGenerator.Generate(100000, 1, 100000, false);

            // Act
            Insertionsort.Sort(input);

            // Assert
            for (int i = 0; i < input.Length - 1; i++)
            {
                Assert.IsTrue(input[i] >= input[i + 1]);
            }
        }

        [TestMethod]
        public void Insertionsort_SortsArrayByWordLength()
        {
            // Arrange
            string[] input = ["banaan", "ei", "appel", "kers"];
            string[] expected = ["ei", "kers", "appel", "banaan"];

            // Act
            Insertionsort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }
    }
}
