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
        private Node root;

        // Tree Class constructor
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
                // Console.WriteLine(stack.Pop().value);
                // // stack.Pop();
                Node node = stack.Pop();
                Console.WriteLine(node.value);
                if (node.left != null)
                {
                    stack.Push(node.left);
                }
                if (node.right != null)
                {
                    stack.Push(node.right);
                }
            }
        }
    }
}