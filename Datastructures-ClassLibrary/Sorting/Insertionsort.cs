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
                    if (i > 0 && key.Length < mijnLijst[i - 1].Length)
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
    }
}
