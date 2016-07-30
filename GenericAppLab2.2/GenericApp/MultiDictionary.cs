using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    class MultiDictionary<K, V> : IMultiDictionary<K, V>, IEnumerable<KeyValuePair<K, IEnumerable<V>>>
        where K : struct
        where V : new()
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
            if (HasKeyAttribute(key))
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
        }
        internal static bool HasKeyAttribute(object key)
        {
            var type = key.GetType();
            var attribute = type.GetCustomAttribute<KeyAttribute>();
            var result = attribute != null;

            if (!result)
            {
                throw new Exception(string.Format("This type doesn't have key attribute {0}",key));
            }
            return result;
            
        }

        public void CreateNewValue(K key)
        {
            if (!_dictionary.ContainsKey(key)) // key doesn't exist in the collection
            {
                Dictionary<K, LinkedList<V>> dic = _dictionary;
                dic = (new Dictionary<K, LinkedList<V>> { { key, new LinkedList<V>() { } } }).Concat(dic).ToDictionary(k => k.Key, v => v.Value);
                this._dictionary = dic;
            }
            else
            {
                V value = new V();
                Add(key, value);
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

        public bool Remove(K key)
        {
            return _dictionary.Remove(key);
        }

        public bool Remove(K key, V value)
        {
                var res = _dictionary[key];
                return res.Remove(value);
        }

        public IEnumerator<KeyValuePair<K, IEnumerable<V>>> GetEnumerator()
        {
            foreach (var pair in _dictionary)
            {
                yield return new KeyValuePair<K, IEnumerable<V>>(pair.Key, pair.Value);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}
