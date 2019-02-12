using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTDDCollection
{
    public class MyListArray<T> : IList<T>, IEnumerator<T>
    {
        #region private fields
        T[] _arr;
        int _count = 0;
        #endregion

        #region .ctor
        public MyListArray(int startCapacity = 10)
        {
            _arr = new T[startCapacity];
            _count = 0;
        }
        #endregion

        #region indexer
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _count)
                    throw new IndexOutOfRangeException();
                return _arr[index];
            }

            set
            {
                if (index < 0 || index >= _count)
                    throw new IndexOutOfRangeException();
                _arr[index] = value;
            }
        }
        #endregion

        public int Count => _count;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            if (_count == _arr.Length)
            {
                Array.Resize(ref _arr, _count + 10);
            }
            _arr[_count++] = item;
        }

        public void Clear()
        {
            _count = 0;
        }

        public bool Contains(T item)
        {

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        #region IEnumerator
        public IEnumerator<T> GetEnumerator()
        {
            return GetEnumerator();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Dispose()
        {
            Reset();
        }

        public bool MoveNext()
        {
            ++_currentIndex;
            return _currentIndex < _count;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }
        #endregion

        #region Enumerator

        int _currentIndex = -1;

        public T Current => _arr[_currentIndex];
        object IEnumerator.Current => Current;

        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
