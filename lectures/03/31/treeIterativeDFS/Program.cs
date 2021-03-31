// Tanis Olesen
// 03/29/2021
// Lecture example and in-class work.

// Depth First Search in a binary tree
//   - You need to have some sort of stack structure to traverse a tree structure
//      - This can be done with either a custom stack structure
//      - Or you can use the runtime stack, and use recursion.
using System;
using System.Collections.Generic;

namespace treeIterativeDFS
{
    class Tree
    {
        // Represents a Node inside of a tree structure
        private class Node
        {
            public int? value;
            public Node left;
            public Node right;

            public Node(int? value)
            {
                this.value = value;
                left = null;
                right = null;
            }
        }
        // Represents the root Node in the tree
        private Node root = null;

        // Tree Class constructor
        // public void Tree()
        // {
        //     root = null;
        // }

        public void TraverseIter()
        {
            if (root != null)
            {
                Stack<Node> stack = new Stack<Node>();
                stack.Push(root);
                // Console.WriteLine(stack.Peek().value);
                while (stack.Count > 0)
                {
                    // Console.WriteLine(stack.Pop().value);
                    // // stack.Pop();
                    Node node = stack.Pop();
                    Console.WriteLine(node.value);
                    // Check right
                    if (node.right != null)
                    {
                        stack.Push(node.right);
                    }
                    // Check left
                    if (node.left != null)
                    {
                        stack.Push(node.left);
                    }
                }
            }
        }

        public void Test()
        {
            // How we would want to use an iterator
            // The variable tree must provide the iterator we want to use
            foreach (Node item in tree) // Range based for loop
            {
                Console.WriteLine(item);
            }
        }

        public System.Collections.Generic.IEnumerator<Node> GetEnumerator()
        {
            throw new System.NotImplementedException();
            yield return default(Node);
        }
    }

    class Program
    {
        public static void Main(String[] args)
        {
            Tree tree = new Tree();
            tree.TraverseIter();
        }
    }
}