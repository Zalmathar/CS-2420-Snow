// Tanis Olesen
// 04/26/2021
// Implementation of a java HashMap into c#.
// https://docs.oracle.com/javase/8/docs/api/java/util/HashMap.html

using System;
using KeyValuePair;
using System.Security.Cryptography;
using System.Text;

namespace HashMap
{
    public class HashMap<K, V> {
        // A map containing key value pairs. 

        private int size = 0; // Represents the number of key-value mappins in this map.
        private int maxSize = 0; // Represents the maximum number of key-value mappins this map can hold.

        private KeyValuePair<byte[], V>[] map; // Represents an array of KeyValuePairs

        private void init(int size) {
            maxSize = size;
            map = new KeyValuePair<byte[], V>[size]; // Store both the key in a byte array to store the HashValue of the key. Value is left alone.
        }

        // Consructor's
        public HashMap() {
            init(10); // default size of 10
        }

        public HashMap(int size) {
            init(size);
        }

        // Returns true if this map contains a mapping for the specified key.
        public bool containsKey(object key) {
            // TODO: 
            return false;
        }

        // Returns true if this map maps one or more keys to the specified value.
        public bool containsValue(object value) {
            // TODO:
            if (size == 0) {
                return true;
            } else {
                return false;
            }
        }
        // Returns true if this map contains no key-value pairs.
        public bool isEmpty() {
            // TODO: 
            return false;
        }

        // Associates the value with the key in the map. Returns: the previous value associated with key, or null if there was no mapping for key. (A null return can also indicate that the map previously associated null with key.)
        public V put(K key, V value) {
            // TODO:
            if (isEmpty()) {
                // Create a new hashMap assign the new value
            } else {
                // add the value to the existing hashMap
            }
            return default(V);
        }
    }
}
