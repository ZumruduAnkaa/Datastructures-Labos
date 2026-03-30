using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.Sorting
{
    public class Mergesort
    {
        public static void Sort(int[] list)
        {
            if (list.Length <= 1)
            {
                return;
            }

            int[] first = new int[list.Length / 2];
            int[] second = new int[list.Length - first.Length];
            Array.Copy(list, 0, first, 0, first.Length);
            Array.Copy(list, first.Length, second, 0, second.Length);

            Sort(first);
            Sort(second);

            int firstIndex = 0, secondIndex = 0;
            int index = 0;
            while (firstIndex < first.Length || secondIndex < second.Length)
            {
                if (secondIndex == second.Length || (firstIndex < first.Length && first[firstIndex] <= second[secondIndex]))
                {
                    list[index++] = first[firstIndex++];
                }
                else
                {
                    list[index++] = second[secondIndex++];
                }
            }
        }

        public static void Sort(string[] list)
        {
            if (list.Length <= 1)
            {
                return;
            }

            string[] first = new string[list.Length / 2];
            string[] second = new string[list.Length - first.Length];
            Array.Copy(list, 0, first, 0, first.Length);
            Array.Copy(list, first.Length, second, 0, second.Length);

            Sort(first);
            Sort(second);

            int firstIndex = 0, secondIndex = 0;
            int index = 0;
            while (firstIndex < first.Length || secondIndex < second.Length)
            {
                if (secondIndex == second.Length || (firstIndex < first.Length && Compare(first[firstIndex], second[secondIndex]) <= 0))
                {
                    list[index++] = first[firstIndex++];
                }
                else
                {
                    list[index++] = second[secondIndex++];
                }
            }
        }

        private static int Compare(string s1, string s2)
        {
            if (s1.Length < s2.Length) return -1;
            if (s1.Length > s2.Length) return +1;
            return s1.CompareTo(s2);
        }
    }
}
