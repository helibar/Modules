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

        /**Consider '_dictionary.Keys' - as simple as that
         * I understand what you did, and it is great that you did it, however Dictionary already does that by himself
         * Have a look for yourself:
         * http://referencesource.microsoft.com/#mscorlib/system/collections/generic/dictionary.cs,9a3c0cb5c149c9f7,references
         */
        public ICollection<K> Keys
        {
            get
            {
                if (_dictionary.Any())
                    return _dictionary.Keys;

                List<K> keys = _dictionary.Keys.ToList();


                /**Bug
                 * 
                 * You are either adding a null reference (if K is a reference type
                 * Or a value type which originally was not in the key collection
                */
                keys.Add(default(K));
                
                return new ReadOnlyCollection<K>(keys);//Very good!
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

        //Member Not implemented
        public bool Contains(K key, V value)
        {
            throw new NotImplementedException();
        }

        //Member Not implemented
        public bool ContainsKey(K key)
        {
            throw new NotImplementedException();
        }

        //Member Not implemented
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
            var res = _dictionary[key];//No check if key exists in dictionary
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
