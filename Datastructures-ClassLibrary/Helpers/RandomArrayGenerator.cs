using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.Helpers
{
    public class RandomArrayGenerator
    {
        /// <summary>
        /// Generate a list of random numbers 
        /// </summary>
        /// <param name="amount">The size of the list</param>
        /// <param name="min">The minimum value</param>
        /// <param name="max">The maximum value</param>
        /// <param name="unique">No 2 numbers can be the same</param>
        /// <returns>The list with random numbers</returns>
        public static int[] Generate(int amount = 10, int min = 0, int max = 10, bool unique = false)
        {
            //Todo: remove this line below
            Random random = new Random();
            int[] result = new int[amount];

            if (unique)
            {
                List<int> used = new List<int>();
                for (int i = 0; i < amount; i++)
                {
                    int number;
                    do
                    {
                        number = random.Next(min, max + 1);
                    } while (used.Contains(number));

                    used.Add(number);
                    result[i] = number;
                }
            }
            else
            {
                for (int i = 0; i < amount; i++)
                {
                    result[i] = random.Next(min, max + 1);
                }
            }

            return result;
        }
    }
}
