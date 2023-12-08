
using System.Collections;

namespace Batch_Recompressor.All_Purpose
{
    internal class ConcurrentList<T> : IList<T>
    {
        private readonly List<T> _storage;
        private readonly object _lock;

        public ConcurrentList() { 
            _storage = new List<T>();
            _lock = new object();
        }

        public bool IsReadOnly => ((IList<T>)_storage).IsReadOnly;

        public void Add(T item)
        {
            lock (_lock)
            {
                _storage.Add(item);
            }
        }

        public void Insert(int index, T item)
        {
            lock (_lock)
            {
                _storage.Insert(index, item);
            }
        }

        public void Sort()
        {
            lock (_lock)
            {
                _storage.Sort();
            }
        }

        public bool Remove(T item)
        {
            lock (_lock)
            {
                return _storage.Remove(item);
            }
        }

        public T this[int index]
        {
            get
            {
                lock (_lock)
                {
                    if (index < 0)
                        index = this.Count - index;

                    return _storage[index];
                }
            }
            set
            {
                lock (_lock)
                {
                    if (index < 0)
                        index = this.Count - index;

                    _storage[index] = value;
                }
            }
        }

        public int Count
        {
            get
            {
                lock (_lock)
                {
                    return _storage.Count;
                }
            }
        }

        public void Clear()
        {
            lock (_lock)
            {
                _storage.Clear();
            }
        }

        public int IndexOf(T item)
        {
            lock (_lock)
            {
                return _storage.IndexOf(item);
            }
        }


        public void CopyTo(T[] array, int arrayIndex)
        {
            lock (_lock)
            {
                _storage.CopyTo(array, arrayIndex);
            }
        }

        public bool Contains(T item)
        {
            lock (_lock)
            {
                return _storage.Contains(item);
            }
        }

        public void RemoveAt(int index)
        {
            lock (_lock)
            {
                _storage.RemoveAt(index);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            lock (_lock)
            {
                return _storage.ToArray().AsEnumerable().GetEnumerator();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
