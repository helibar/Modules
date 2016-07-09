using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    class MultiDictionary<K, V> : IMultiDictionary<K, V>, IEnumerable<KeyValuePair<K, IEnumerable<V>>>
    {
        Dictionary<K, LinkedList<V>> _dictionary = new Dictionary<K, LinkedList<V>>();

        public int Count
        {
            get
            {
                return _dictionary.Count();
            }
        }

        public ICollection<K> Keys
        {
            get
            {
                if (_dictionary.Any())
                    return _dictionary.Keys;

                List<K> keys = _dictionary.Keys.ToList();
                keys.Add(default(K));
                return new ReadOnlyCollection<K>(keys);
            }
        }

        public ICollection<V> Values
        {
            get
            {
                List<V> values = new List<V>();

                foreach (var valuesLst in _dictionary.Values)
                {
                    foreach (var value in valuesLst)
                    {
                        values.Add(value);
                    }
                }
                return values;
            }
        }

        public void Add(K key, V value)
        {
            if (!_dictionary.ContainsKey(key))
            {
                _dictionary.Add(key, new LinkedList<V>() { });
                _dictionary[key].AddLast(value);
            }
            else
            {
                _dictionary[key].AddLast(value);
            }

        }

        public void Clear()
        {
            _dictionary.Clear();
        }

        public bool Contains(K key, V value)
        {
            throw new NotImplementedException();
        }

        public bool ContainsKey(K key)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<K, IEnumerable<V>>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(K key)
        {
            return _dictionary.Remove(key);
        }

        public bool Remove(K key, V value)
        {
            var res = _dictionary[key];
            return res.Remove(value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var list in _dictionary)
                foreach (var value in list.Value)
                    yield return new KeyValuePair<K, V>(list.Key, value);
        }


    }
}
