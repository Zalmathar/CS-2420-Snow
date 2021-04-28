// Tanis Olesen
// 04/28/2021
// Tests the KeyValuePair class
using System;
using System.IO;
using System.Diagnostics;

namespace KeyValuePair {
    public class KeyValuePairTest {
        public static void runTests() {
            MyKeyValuePair<string, int> pair = new MyKeyValuePair<string, int>("one", 1);
            try {
                Debug.Assert(pair.key == "one");
                Debug.Assert(pair.value == 1);
            } catch (Exception e) {
                Console.WriteLine($"test KeyValuePair Failed {e.Message}");
            }
        }
    }
}