// Tanis Olesen
// 04/26/2021
// Implementation of a java HashMap into c#.
// https://docs.oracle.com/javase/8/docs/api/java/util/HashMap.html

using System;

namespace HashMap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class HashMap<K, V> {
        // A map containing key value pairs. 
        
        // Returns true if this map contains a mapping for the specified key.
        public bool containsKey(object key) {
            // TODO: 
            return false;
        }

        // Returns true if this map maps one or more keys to the specified value.
        public bool containsValue(object value) {
            // TODO:
            return false;
        }
        // Returns true if this map contains no key-value pairs.
        public bool isEmpty() {
            // TODO: 
            return false;
        }

        // Associates the value with the key in the map. Returns: the previous value associated with key, or null if there was no mapping for key. (A null return can also indicate that the map previously associated null with key.)
        public V put(K key, V value) {
            // TODO:
        }
    }
}
