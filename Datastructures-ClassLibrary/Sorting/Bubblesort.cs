using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.Sorting
{
    public class Bubblesort
    {
        /// <summary>
        /// Sort the given input (list of integers) in ascending order 
        /// (from smallest to the largest number)
        /// The list is sorted 'in-place' and since an array is passed
        /// 'by-reference' there is no return value
        /// </summary>
        /// <param name="input">list of numbers</param>
        public static void Sort(int[] input)
        {
            int[] mijnLijst = input;

            int iterations = mijnLijst.Length - 1;

            if (input is not null)
            {
                while (iterations >= 1)
                {
                    for (global::System.Int32 i = 0; i < iterations; i++)
                    {
                        int item1 = mijnLijst[i];
                        int item2 = mijnLijst[i + 1];
                        if (item1 > item2)
                        {
                            mijnLijst[i] = item2;
                            mijnLijst[i + 1] = item1;
                        }
                    }
                    iterations--;
                }
            }

        }

        /// <summary>
        /// Sort the given list using the adaptive version of the
        /// bubble sort algorithm
        /// </summary>
        /// <param name="input"></param>
        /// <returns>    
        public static int SortAdaptive(int[] input)
        {
            int iterations = input.Length - 1;
            int aantalIteraties = 0;

            while (iterations >= 1)
            {
                bool swapGebeurd = false;

                for (int i = 0; i < iterations; i++)
                {
                    int item1 = input[i];
                    int item2 = input[i + 1];
                    if (item1 > item2)
                    {
                        input[i] = item2;
                        input[i + 1] = item1;
                        swapGebeurd = true;
                    }
                }

                aantalIteraties++;
                iterations--;

                if (swapGebeurd == false)
                {
                    break;
                }
            }

            return aantalIteraties;
        }

        /// <summary>
        /// Compare the 2 numbers and return a value that indicates their sort order.
        /// </summary>
        /// <param name="n1">number 1</param>
        /// <param name="n2">number 2</param>
        /// <returns>
        /// Return -1 if n1 preceeds n2
        /// Return +1 of n1 follows n2 
        /// Return 0 if both numbers occur in the same position.
        /// </returns>
        private static int Compare(double n1, double n2)
        {
            return 0;
        }
    }
}
