using System;
using System.Collections.Generic;
using System.Text;

namespace KeyValueStore
{
    public struct KeyValue<Value>
    {
        public readonly string key;

        public Value value { get; }
        public KeyValue(string setKey, Value setValue)
        {
            key = setKey;
            value = setValue;
        }
    }
}
