using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.Sorting
{
    public class Insertionsort
    {
        public static void Sort(int[] input)
        {
            int[] mijnLijst = input;

            // De start index van het niet-gesorteerde deel
            int startIndex = 1;

            while (startIndex < mijnLijst.Length)
            {
                int key = mijnLijst[startIndex];

                for (int i = startIndex; i >= 0; i--)
                {
                    if (i > 0 && key > mijnLijst[i-1])
                    {
                        mijnLijst[i] = mijnLijst[i - 1];
                    }
                    else
                    {
                        mijnLijst[i] = key;
                        break;
                    }

                }
                startIndex++;
            }
        }

        public static void Sort(string[] input)
        {
            string[] mijnLijst = input;

            // De start index van het niet-gesorteerde deel
            int startIndex = 1;

            while (startIndex < mijnLijst.Length)
            {
                string key = mijnLijst[startIndex];

                for (int i = startIndex; i >= 0; i--)
                {
                    if (i > 0 && Compare(key, mijnLijst[i - 1]) < 0)
                    {
                        mijnLijst[i] = mijnLijst[i - 1];
                    }
                    else
                    {
                        mijnLijst[i] = key;
                        break;
                    }

                }
                startIndex++;
            }
        }

        /// <summary>
        /// Compare the 2 words and return a value that indicates their sort order.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns>
        /// Return -1 if s1 preceeds s2
        /// Return +1 of s1 follows s2 
        /// Return 0 if both words occur in the same position
        /// </returns>
        private static int Compare(string s1, string s2)
        {
            if (s1.Length < s2.Length) return -1;
            if (s1.Length > s2.Length) return +1;
            return s1.CompareTo(s2);
        }
    }
}
