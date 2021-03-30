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
    class tree
    {
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
        private Node root;

        public void Tree()
        {
            root = null;
        }

        public void TraverseIter()
        {
            Stack<Node> stack = new Stack<Node>();
            stack.Push(root);
            // Console.WriteLine(stack.Peek().value);


            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop().value);
                // stack.Pop();
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}
