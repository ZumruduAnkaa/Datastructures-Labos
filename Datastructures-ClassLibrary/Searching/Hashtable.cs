using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.Searching
{
    public class Hashtable
    {
        private string[] _array;
        public Hashtable(int size)
        {
            _array = new string[size];
        }

        public void AddItem(string text)
        {
            int index = CalcIndex(text);

            if (_array[index] != null)
            {
                throw new Exception("Collision!");
            }
            else
            {
                _array[index] = text;
            }
        }

        public int FindItem(string text)
        {
            int index = CalcIndex(text);

            if (_array[index] == text)
            {
                return index;
            }
            else
            {
                return -1;
            }
        }

        private int CalcIndex(string text)
        {
            return Math.Abs(text.GetHashCode() % _array.Length);
        }



    }
}
