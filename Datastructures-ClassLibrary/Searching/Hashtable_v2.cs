using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.Searching
{
    public class Hashtable_v2
    {
        private LinkedList<string>[] _array;

        public Hashtable_v2(int size)
        {
            _array = new LinkedList<string>[size];

            for (int i = 0; i < size; i++)
            {
                _array[i] = new LinkedList<string>();
            }
        }

        public void AddItem(string text)
        {
            int index = CalcIndex(text);
            _array[index].AddLast(text);
        }

        public int FindItem(string text)
        {
            int index = CalcIndex(text);

            if (_array[index].Contains(text))
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
