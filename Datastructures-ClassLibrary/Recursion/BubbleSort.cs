using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.Recursion
{
    public class BubbleSort
    {
        public static void SortRecursive(int[] list)
        {
            SortRecursive(list, list.Length - 1);
        }

        private static void SortRecursive(int[] list, int length)
        {
            if (length <= 1)
            {
                return;
            }

            for (int i = 0; i < length; i++)
            {
                if (list[i] > list[i + 1])
                {
                    int temp = list[i];
                    list[i] = list[i + 1];
                    list[i + 1] = temp;
                }
            }

            SortRecursive(list, length - 1);
        }
    }
}
