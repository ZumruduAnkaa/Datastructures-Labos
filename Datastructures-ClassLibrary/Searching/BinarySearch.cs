using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.Searching
{
    public class BinarySearch
    {
        /// <summary>
        /// Find the given value in the list using the binary search algoritm.
        /// Note that the given list must be sorted ascending before using this method !
        /// </summary>
        /// <param name="list"></param>
        /// <param name="value"></param>
        /// <returns>the index in the array where the value was found, or -1 if not found</returns>
        public static int Find(int[] list, int value)
        {
            return Find(list, value, 0, list.Length -1);
        }

        private static int Find(int[] list, int value, int minIndex, int maxIndex)
        {
            if (minIndex > maxIndex)
            {
                return -1;
            }

            int midden = (minIndex + maxIndex) / 2;

            if (list[midden] == value)
            {
                return midden;
            }

            if (minIndex == maxIndex)
            {
                return -1;
            }
            if (value < list[midden])
            {
                return Find(list, value, minIndex, midden - 1);
            }

            return Find(list, value, midden + 1, maxIndex);
        }


        /// <summary>
        /// Find the given value in de list using the binary search.
        /// The list must be sorted by the insertionsort, using a comparer helper method
        /// that sorts words by their length ascending and secondly alphabetically (for same length words)
        /// This means that we must use the same comparer here to find the values
        /// </summary>
        /// <param name="list"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int Find(string[] list, string value)
        {
            return Find(list, value, 0, list.Length - 1);
        }

        private static int Find(string[] list, string value, int minIndex, int maxIndex)
        {
            if (minIndex > maxIndex)
                return -1;

            int midden = (minIndex + maxIndex) / 2;

            if (Compare(value, list[midden]) == 0)
                return midden;

            if (Compare(value, list[midden]) < 0)
                return Find(list, value, minIndex, midden - 1);

            return Find(list, value, midden + 1, maxIndex);
        }

        private static int Compare(string s1, string s2)
        {
            if (s1.Length < s2.Length) return -1;
            if (s1.Length > s2.Length) return +1;
            return s1.CompareTo(s2);
        }
    }
}
