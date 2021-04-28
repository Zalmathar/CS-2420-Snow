// Tanis Olesen
// 04/28/2021
// Represts a KeyValuePair

namespace KeyValuePair {
    public class MyKeyValuePair<K, V> {
        public K key;
        public V value;

        public MyKeyValuePair(K key, V value) {
            this.key = key;
            this.value = value;
        }
    }
}