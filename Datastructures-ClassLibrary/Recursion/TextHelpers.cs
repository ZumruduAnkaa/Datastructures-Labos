using Datastructures_ClassLibrary.LineairStructures;
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

        public static List<char> SplitString(string word)
        {
            List<char> list = new List<char>();
            SplitString(word, list);
            return list;
        }

        private static void SplitString(string word, List<char> list)
        {
            if (word == "")
            {
                
            }
            else
            {
                list.Add(word[0]);
                SplitString(word.Substring(1), list);
            }
        }


        //Oefening: Tekst omkeren (recursief) naar een Queue
        public static void ReverseText(string text, QueueString queue)
        {
            if (text == "")
            {
                return;
            }

            ReverseText(text.Substring(1), queue);
            queue.Enqueue(text[0].ToString());
        }
    }
}
