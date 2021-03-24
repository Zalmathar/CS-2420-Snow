// Tanis Olesen
// 03/22/2021
// Tests the functionality of the MyBinaryTree class.

using System;

namespace MyBinaryTree
{
    // Represents a failed test
    [System.Serializable]
    public class FailedTestException : System.Exception
    {
        public FailedTestException(string message) : base(message) { }
    }
    public class MyBinaryTreeTest
    {
        public static void runTests()
        {
            try
            {
                testEmpty();
                testToArray();
                testAddNodePreSorted();
                testAddNodeReverse();
            }
            catch (FailedTestException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // Tests the empty() function
        private static void testEmpty()
        {
            MyBinaryTree tree = new MyBinaryTree();
            if (tree.empty().Equals(false))
            {
                throw new FailedTestException("testEmpty() returned false when it is empty");
            }
            else
            {
                // good
            }
            tree.addNode(1);
            if (tree.empty().Equals(true))
            {
                throw new FailedTestException("testEmpty() Returned true when it was supposed to be false");
            }
            else
            {
                // good
            }
            Console.WriteLine("testEmpty() Passes all tests.");
        }

        private static void testToArray()
        {
            MyBinaryTree tree = new MyBinaryTree();
            tree.addNode(1);
            tree.addNode(2);
            tree.addNode(3);
            int?[] check = { 1, 2, 3 };
            int?[] test = tree.toArray();

            for (int i = 0; i < test.Length; i++)
            {
                // Console.WriteLine(test[i]);
                if (check[i] != test[i] || check.Length != test.Length)
                {
                    throw new FailedTestException("testToArray() failed " + check + " Does not equal " + tree.toArray());
                }
            }

            Console.WriteLine("testToArray() Passes all tests.");
        }

        // Adds all of the nodes in the tree in reverse order compaired to the check array. 
        // Also tests to see if tree will automatically sort the input
        private static void testAddNodePreSorted()
        {
            // First Part of Test
            MyBinaryTree tree = new MyBinaryTree();

            if (tree.empty().Equals(false))
            {
                throw new FailedTestException("Empty() Retruned false when it should be true in testAddNode.");
            }
            int[] check = new int[1000];

            for (int i = 0; i > 1000; i++)
            {
                check[i] = i;
                tree.addNode(i);
            }

            int?[] test = tree.toArray();

            for (int i = 0; i < test.Length; i++)
            {
                if (check[i] != test[i] || check.Length != test.Length)
                {
                    throw new FailedTestException("testAddNodePreSorted() failed " + check + " Does not equal " + tree.toArray());
                }
            }

            Console.WriteLine("testAddNodePreSorted() Passes all tests");
        }

        private static void testAddNodeReverse()
        {
            // First Part of Test
            MyBinaryTree tree = new MyBinaryTree();

            if (tree.empty().Equals(false))
            {
                throw new FailedTestException("Empty() Retruned false when it should be true in testAddNode.");
            }
            int[] check = new int[1000];

            for (int i = 0; i > 1000; i++)
            {
                check[i] = i;
            }

            for (int i = 1000; i < 0; i--)
            {
                tree.addNode(i);
            }

            int?[] test = tree.toArray();

            for (int i = 0; i < test.Length; i++)
            {
                if (check[i] != test[i] || check.Length != test.Length)
                {
                    throw new FailedTestException("testAddNodeReverse() failed " + check + " Does not equal " + tree.toArray());
                }
            }

            Console.WriteLine("testAddNodeReverse() Passes all tests");
        }
    }
}