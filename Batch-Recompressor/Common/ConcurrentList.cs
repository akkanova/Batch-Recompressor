using System.Collections;

namespace Batch_Recompressor.Common
{
    public class ConcurrentList<T> : IList<T>, IList
    {
        private readonly List<T> _storage;
        private readonly object _lock;

        public ConcurrentList() { 
            _storage = new List<T>();
            _lock = new object();
        }

        public bool IsReadOnly          => false;
        bool ICollection.IsSynchronized => true;
        bool IList.IsFixedSize          => false;

        object ICollection.SyncRoot => _lock;


        object? IList.this[int index] 
        { 
            get => this[index];
            set 
            {
                if (value is not null)
                    this[index] = (T) value;
            }
        }

        public T this[int index]
        {
            get
            {
                lock (_lock)
                {
                    if (index < 0)
                        index = Count - index;

                    return _storage[index];
                }
            }
            set
            {
                lock (_lock)
                {
                    if (index < 0)
                        index = Count - index;

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

        int IList.Add(object? value)
        {
            if (value is null)
                return -1;

            lock (_lock)
            {
                _storage.Add((T) value);
                return Count;
            }
        }

        public void Add(T item)
        {
            lock (_lock)
            {
                _storage.Add(item);
            }
        }

        void IList.Insert(int index, object? value)
        {
            if (value is not null)
                Insert(index, (T) value);
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

        void IList.Remove(object? value)
        {
            if (value is not null)
                Remove((T) value);
        }

        public bool Remove(T item)
        {
            lock (_lock)
            {
                return _storage.Remove(item);
            }
        }

        public void Clear()
        {
            lock (_lock)
            {
                _storage.Clear();
            }
        }


        int IList.IndexOf(object? value) => value is not null
            ? IndexOf((T) value) : -1;

        public int IndexOf(T item)
        {
            lock (_lock)
            {
                return _storage.IndexOf(item);
            }
        }

        void ICollection.CopyTo(Array array, int index) => CopyTo((T[]) array, index);

        public void CopyTo(T[] array, int arrayIndex)
        {
            lock (_lock)
            {
                _storage.CopyTo(array, arrayIndex);
            }
        }

        bool IList.Contains(object? value) => value is not null 
               ? Contains((T) value) : false;

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

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
