using System;
using System.IO;
using System.Diagnostics;

namespace HashMap
{
    public class HashMapTest {
        public static void runTests() {
            // Calls all of the test funcitons
            HashMap<string, int> numbers = new HashMap<string, int>();
            testPut(ref numbers);
            testContainsKey(numbers);
            testContainsValue(numbers);
        }

        private static void testPut(ref HashMap<string, int> numbers) { // using ref because we are changing values,
            try {
                Debug.Assert(numbers.isEmpty() == true);
                numbers.put("one", 1);
                numbers.put("two", 2);
                numbers.put("three", 3);
                Debug.Assert(numbers.isEmpty() == false);
            } catch(Exception e) {
                Console.WriteLine($"testPut Failed. {e.Message}");
            }
        }

        private static void testContainsKey(HashMap<string, int> numbers) {
            try {
                Debug.Assert(numbers.containsKey("one") == true);
                Debug.Assert(numbers.containsKey("two") == true);
                Debug.Assert(numbers.containsKey("three") == true);
                Debug.Assert(numbers.containsKey("four") == false);
            } catch(Exception e) {
                Console.WriteLine($"testContainsKey Failed. {e.Message}");
            }
        }

        private static void testContainsValue(HashMap<string, int> numbers) {
            try {
                Debug.Assert(numbers.containsValue(1) == true);
                Debug.Assert(numbers.containsValue(2) == true);
                Debug.Assert(numbers.containsValue(3) == true);
                Debug.Assert(numbers.containsValue(4) == false);
            } catch(Exception e) {
                Console.WriteLine($"testContainsvalue Failed. {e.Message}");
            }
        }
    }
}