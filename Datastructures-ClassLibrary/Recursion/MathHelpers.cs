using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.Recursion
{
    public class MathHelpers
    {
        public static int CalculateNumberOfDigits(int number)
        {
            if (number < 0)
            {
                number = Math.Abs(number);
            }

            if (number < 10)
            {
                return 1;
            }

            return 1 + CalculateNumberOfDigits(number / 10);
        }

        public static int CalculateFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            if (number < 0)
            {
                throw new ArgumentException("Negatief getal is ongeldige input");
            }

            return number * CalculateFactorial(number - 1);
        }
    }
}
