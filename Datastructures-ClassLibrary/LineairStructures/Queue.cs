using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.LineairStructures
{
    public class Queue
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


        public void Enqueue(int item)
        {
            if (IsFull)
            {
                if (_canGrow)
                {
                    int[] newArray = new int[_array.Length * 2];

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

        public int Dequeue()
        {
            if (IsEmpty)
            {
                throw new Exception("De queue is leeg");
            }
            int temp = _array[0];

            for (int i = 0; i < _rearIndex; i++)
            {
                _array[i] = _array[i + 1];
            }

            _rearIndex--;
            return temp;
        }


        private int[] _array = new int[10];
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

        public Queue(int capacity = 10, bool canGrow = false)
        {
            _array = new int[capacity];
            this.capacity = capacity;
            _canGrow = canGrow;
        }
    }
}
