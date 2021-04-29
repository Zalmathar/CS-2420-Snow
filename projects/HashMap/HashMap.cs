// Tanis Olesen
// 04/26/2021
// Implementation of a java HashMap into c#.
// https://docs.oracle.com/javase/8/docs/api/java/util/HashMap.html

using System;
using KeyValuePair;
using LinkedList;

namespace HashMap
{
    public class HashMap<K, V>
    {
        // A map containing key value pairs. 

        private int size; // Represents the number of key-value mappins in this map.
        private int maxSize; // Represents the maximum number of key-value mappins this map can hold.

        private MyLinkedList<MyKeyValuePair<K, V>>[] map; // Represents an array of KeyValuePairs

        private void init(int size)
        {
            this.size = 0;
            maxSize = size;
            map = new MyLinkedList<MyKeyValuePair<K, V>>[size];
        }

        // Consructor's
        public HashMap()
        {
            init(10); // default size of 10
        }

        public HashMap(int size)
        {
            init(size);
        }

        // Returns true if this map contains a mapping for the specified key.
        public bool containsKey(K key)
        {
            var location = Math.Abs(key.GetHashCode() % (maxSize));
            if (map[location] != null) {
                foreach (MyKeyValuePair<K, V> pair in map[location])
                {
                    if (pair != null) {
                        if (pair.key.Equals(key))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        // Returns true if this map maps one or more keys to the specified value.
        public bool containsValue(V value)
        {
            foreach (MyLinkedList<MyKeyValuePair<K, V>> list in map)
            {
                if (list != null) {
                    foreach (MyKeyValuePair<K, V> pair in list)
                    {
                        if (pair.value.Equals(value))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        // Returns the value associated with the key.
        public V get(K key)
        {
            // return map[Math.Abs(key.GetHashCode() % maxSize)].value;
            var location = Math.Abs(key.GetHashCode() % (maxSize));
            if (map[location] != null) {
                foreach (MyKeyValuePair<K, V> pair in map[location])
                {
                    if (pair != null) {
                        if (pair.key.Equals(key))
                        {
                            return pair.value;
                        }
                    }
                }
            }
            return default(V);
        }

        // Returns true if this map contains no key-value pairs.
        public bool isEmpty()
        {
            if (size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Retruns a collection of the values contained in this map
        public V[] values()
        {
            // TODO:
            V[] values = new V[size];
            int i = 0;
            foreach (MyLinkedList<MyKeyValuePair<K, V>> list in map)
            {
                if (list != null) {
                    foreach (MyKeyValuePair<K, V> pair in list)
                    {
                        if (pair != null) {
                            values[i] = pair.value;
                            i++;
                        }
                    }
                }
            }
            return values;
        }

        // Associates the value with the key in the map. Returns: the previous value associated with key, or null if there was no mapping for key. (A null return can also indicate that the map previously associated null with key.)
        public void put(K key, V value)
        {
            if (size + 1 > maxSize)
            {
                // Copy and create a new array.
                MyLinkedList<MyKeyValuePair<K, V>>[] oldMap = map;
                init(maxSize * 2);
                foreach (MyLinkedList<MyKeyValuePair<K, V>> list in oldMap)
                {
                    if (list != null) {
                        foreach (MyKeyValuePair<K, V> pair in list)
                        {
                            if (pair != null) {
                                put(pair.key, pair.value);
                            }
                        }
                    }
                }
            }

            var location = Math.Abs(key.GetHashCode() % (maxSize));
            var node = new MyKeyValuePair<K, V>(key, value);
            if (this.map[location] == null) {
                map[location] = new MyLinkedList<MyKeyValuePair<K, V>>();
                this.map[location].AddLast(node);
            } else {
                this.map[location].AddLast(node);
            }
            size++;
        }
    }
}
