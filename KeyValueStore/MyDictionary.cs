using System;
using System.Collections.Generic;
using System.Text;

namespace KeyValueStore
{
    public class MyDictionary<Value>
    {
        KeyValue<Value>[] keyValueArray = new KeyValue<Value>[10];
        private int storedValues;

        public Value this[string key]
        {
            get
            {
                for (int i = 0; i < keyValueArray.Length; i++)
                {
                    if (keyValueArray[i].key == key)
                        return keyValueArray[i].value;
                }
                throw new KeyNotFoundException(key);
            }
            set
            {
                for (int i = 0; i < keyValueArray.Length; i++)
                {
                    if (keyValueArray[i].key == key)
                    {
                        keyValueArray[i] = new KeyValue<Value>(key, value);
                        return;
                    }
                    if (keyValueArray[i].key == null)
                    {
                        keyValueArray[i] = new KeyValue<Value>(key, value);
                        storedValues++;
                        return;
                    }
                }
            }
        }
    }
}
