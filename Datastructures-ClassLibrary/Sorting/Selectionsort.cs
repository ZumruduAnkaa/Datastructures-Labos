using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.Sorting
{
    public class Selectionsort
    {
        public static void Sort(int[] input)
        {
            int[] mijnLijst = input;

            int startIndex = 0;

            while (startIndex < mijnLijst.Length - 1)
            {
                int smallestIndex = startIndex;
                for (int i = startIndex + 1; i < mijnLijst.Length; i++)
                {
                    if (mijnLijst[i] < mijnLijst[smallestIndex])
                    {
                        smallestIndex = i;
                    }

                }

                // wissel de eerste niet-gesorteerde waarde met de kleinste waarde
                int smallestValue = mijnLijst[smallestIndex];
                mijnLijst[smallestIndex] = mijnLijst[startIndex];
                mijnLijst[startIndex] = smallestValue;

                //Verhoog de startIndex van de niet-gesorteerde lijst
                startIndex++;
            }
        }

        public static void Sort(string[] input)
        {
            string[] mijnLijst = input;

            int startIndex = 0;

            while (startIndex < mijnLijst.Length - 1)
            {
                int smallestIndex = startIndex;
                for (int i = startIndex + 1; i < mijnLijst.Length; i++)
                {
                    if (input[i].CompareTo(input[smallestIndex]) < 0)
                    {
                        smallestIndex = i;
                    }

                }

                // wissel de eerste niet-gesorteerde waarde met de kleinste waarde
                string smallestValue = mijnLijst[smallestIndex];
                mijnLijst[smallestIndex] = mijnLijst[startIndex];
                mijnLijst[startIndex] = smallestValue;

                //Verhoog de startIndex van de niet-gesorteerde lijst
                startIndex++;
            }
        }
    }
}
