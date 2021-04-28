// Tanis Olesen
// 04/26/2021
// Implementation of a java HashMap into c#.
// https://docs.oracle.com/javase/8/docs/api/java/util/HashMap.html

using System;
using KeyValuePair;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;

namespace HashMap
{
    public class HashMap<K, V>
    {
        // A map containing key value pairs. 

        private int size; // Represents the number of key-value mappins in this map.
        private int maxSize; // Represents the maximum number of key-value mappins this map can hold.

        private LinkedList<MyKeyValuePair<K, V>>[] map; // Represents an array of KeyValuePairs

        private void init(int size)
        {
            this.size = 0;
            maxSize = size;
            map = new LinkedList<MyKeyValuePair<K, V>>[size]; // Store both the key in a byte array to store the HashValue of the key. Value is left alone.
        }

        // Consructor's
        public HashMap()
        {
            init(3); // default size of 10
        }

        public HashMap(int size)
        {
            init(size);
        }

        // Returns true if this map contains a mapping for the specified key.
        public bool containsKey(K key)
        {
            foreach (MyKeyValuePair<K, V> pair in map[Math.Abs(key.GetHashCode() % (maxSize))])
            {
                if (pair.key.Equals(key))
                {
                    return true;
                }
            }
            return false;
        }

        // Returns true if this map maps one or more keys to the specified value.
        public bool containsValue(V value)
        {
            foreach (LinkedList<MyKeyValuePair<K, V>> list in map)
            {
                foreach (MyKeyValuePair<K, V> pair in list)
                {
                    if (pair.value.Equals(value))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        // Returns the value associated with the key.
        public V get(K key)
        {
            // return map[Math.Abs(key.GetHashCode() % maxSize)].value;
            foreach (MyKeyValuePair<K, V> pair in map[Math.Abs(key.GetHashCode() % (maxSize))])
            {
                if (pair.key.Equals(key))
                {
                    return pair.value;
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
            foreach (LinkedList<MyKeyValuePair<K, V>> list in map)
            {
                foreach (MyKeyValuePair<K, V> pair in list)
                {
                    values[i] = pair.value;
                    i++;
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
                LinkedList<MyKeyValuePair<K, V>>[] oldMap = map;
                init(maxSize * 2);
                foreach (LinkedList<MyKeyValuePair<K, V>> list in map)
                {
                    foreach (MyKeyValuePair<K, V> pair in list)
                    {
                        put(pair.key, pair.value);
                    }
                }
            }

            map[Math.Abs(key.GetHashCode() % (maxSize))].AddLast(new MyKeyValuePair<K, V>(key, value));
            size++;
        }
    }
}
