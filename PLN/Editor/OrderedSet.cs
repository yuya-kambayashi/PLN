using System.Collections;
using System.Collections.Generic;

namespace PLN
{
    public class OrderedSet<T> : IEnumerable<T>
    {
        private readonly LinkedList<T> _list = new();

        public int Count => _list.Count;

        public bool IsReadOnly => false;

        public bool Add(T item)
        {
            if (_list.Contains(item)) return false; // O(n)

            _list.AddLast(item);

            return true;
        }

        public bool Remove(T item)
        {
            return _list.Remove(item); // O(n)
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(T item)
        {
            return _list.Contains(item); // O(n)
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // 先頭取得（便利用）
        public T First => _list.First.Value;
    }
}