using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.LineairStructures
{
    public class QueueString
    {
        private int count;

        public int Count
        {
            get { return _rearIndex + 1; }
            set { count = value; }
        }

        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }


        public void Enqueue(string item)
        {
            if (IsFull)
            {
                if (_canGrow)
                {
                    string[] newArray = new string[_array.Length * 2];

                    Array.Copy(_array, newArray, _array.Length);
                    _array = newArray;
                    capacity = _array.Length;
                }
                else
                {
                    throw new Exception("De queue is volzet");
                }
            }

            ++_rearIndex;
            _array[_rearIndex] = item;
        }

        public string Dequeue()
        {
            if (IsEmpty)
            {
                throw new Exception("De queue is leeg");
            }
            string temp = _array[0];

            for (int i = 0; i < _rearIndex; i++)
            {
                _array[i] = _array[i + 1];
            }

            _rearIndex--;
            return temp;
        }


        private string[] _array = new string[10];
        private int _rearIndex = -1;
        private bool _canGrow = false;


        public bool IsFull
        {
            get { return _rearIndex >= _array.Length - 1; }
        }
        public bool IsEmpty
        {
            get { return _rearIndex == -1; }
        }

        public QueueString(int capacity = 10, bool canGrow = true)
        {
            _array = new string[capacity];
            this.capacity = capacity;
            _canGrow = canGrow;
        }

    
    }
}
