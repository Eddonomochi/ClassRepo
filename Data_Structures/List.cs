using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures
{
    public class List<T> where T : IComparable, IEquatable<T>
    {
        const int DEFAULT_ARRAY_LENGTH = 4;



        private T[] _items;

        private int _count;
        private int _currentLength = DEFAULT_ARRAY_LENGTH;

        public List()
        {
            _items = new T[DEFAULT_ARRAY_LENGTH];
        }

        public List(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException("Your capicity cannot be lower than 0");
            }

            _items = new T[capacity];
        }

        public int Count => _count;

        public void Add(T item)
        {
            var position = _count;

            if (position >= _items.Length)
            {
                HandleArrayResize();
            }

            _items[position] = item;
            _count = position + 1;
        }

        private void HandleArrayResize()
        {

            var currentArray = _items;
            _items = new T[_currentLength * 2];
            currentArray.CopyTo(_items, 0);

            _currentLength *= 2;
        }
    }
}
