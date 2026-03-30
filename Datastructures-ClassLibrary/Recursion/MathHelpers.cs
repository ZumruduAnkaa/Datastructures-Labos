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

        public static uint FibonacciNr(uint n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }

            return FibonacciNr(n - 1) + FibonacciNr(n-2);
        }

        public static string FibonacciSerie(uint count)
        {
            if (count == 1)
            {
                return "0";
            }

            string vorigeReeks = FibonacciSerie(count - 1);
            uint volgendGetal = FibonacciNr(count - 1);

            return vorigeReeks + " " + volgendGetal;

        }
    }
}
