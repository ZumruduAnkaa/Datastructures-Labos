using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.Recursion
{
    public class TextHelpers
    {
        public static int CalculateWordLength(string word)
        {
            if (word == "")
            {
                return 0;
            }
            else
            {
                return 1 + CalculateWordLength(word.Substring(1));
            }

        }

        public static string ReverseText(string text)
        {
            if (text == "")
            {
                return "";
            }
            else
            {
                return ReverseText(text.Substring(1)) + text[0];
            }

        }
    }
}
