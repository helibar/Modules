using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    public class DictionaryEnum<K, V> : IEnumerator
    {
        int position = -1;

        private Dictionary<K, LinkedList<V>> _dic;

        public DictionaryEnum(Dictionary<K, LinkedList<V>> dictionary)
        {
            _dic = dictionary;
        }

        public object Current
        {
            get
            {
                return Current;
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < _dic.Count);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
