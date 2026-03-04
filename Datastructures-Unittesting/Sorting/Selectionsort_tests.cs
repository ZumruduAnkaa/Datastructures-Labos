using Datastructures_ClassLibrary.Helpers;
using Datastructures_ClassLibrary.Sorting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_Unittesting.Sorting
{
    [TestClass]
    public class Selectionsort_tests
    {
        [TestMethod]
        public void Selectionsort_SortsArrayInAscendingOrder()
        {
            // Arrange
            int[] input = [5, 2, 9, 1, 5, 6];
            int[] expected = [1, 2, 5, 5, 6, 9];

            // Act
            Selectionsort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void Selectionsort_SortsLargeArrayInAscendingOrder()
        {
            // Arrange
            int[] input = RandomArrayGenerator.Generate(100000, 1, 100000, false);

            // Act
            Selectionsort.Sort(input);

            // Assert
            for (int i = 0; i < input.Length - 1; i++)
            {
                Assert.IsTrue(input[i] <= input[i + 1]);
            }
        }

        [TestMethod]
        public void Selectionsort_HandlesEmptyArray()
        {
            // Arrange
            int[] input = [];
            int[] expected = [];

            // TODO: put here your test code
            Selectionsort.Sort(input);

            Assert.AreEqual(0, input.Length);
        }

        [TestMethod]
        public void Selectionsort_HandlesSingleElementArray()
        {
            // Arrange
            int[] input = [42];
            int[] expected = [42];

            Selectionsort.Sort(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void Selectionsort_HandlesAlreadySortedArray()
        {
            int[] input = [1, 2, 3, 4, 7, 9];
            int[] expected = [1, 2, 3, 4, 7, 9];

            Selectionsort.Sort(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void Selectionsort_MeetPerformantie()
        {
            // Arrange
            int[] input = RandomArrayGenerator.Generate(100000, 1, 100000, false);

            // Act
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Selectionsort.Sort(input);
            sw.Stop();

            // Output
            Console.WriteLine($"Selection Sort: {sw.ElapsedMilliseconds} ms");

            // Geen echte Assert nodig, gewoon meten
            Assert.IsTrue(sw.ElapsedMilliseconds >= 0);
        }


        // Letters
        [TestMethod]
        public void Selectionsort_SortsArrayInAscendingOrderLetter()
        {
            // Arrange
            string[] input = ["c", "a", "e", "z", "p", "f"];
            string[] expected = ["a", "c", "e", "f", "p", "z"];

            // Act
            Selectionsort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }
    }
}
