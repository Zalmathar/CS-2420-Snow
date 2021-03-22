// Tanis Olesen
// 03/22/2021
/*
    A binary search tree data structure. Each node contains an integer value
    The left of the subree is less than the nodes value
    The right of the subtree is greater than the nodes value
*/

using System;

namespace MyBinaryTree
{

    class MyBinaryTree
    {
        /*
            Represents a Node inside of a binary search tree.
            Contains two pointers to subnodes in the tree.
            Left is representitive of nodes less than the current nodes value
            Right is representitive of nodes greater than the current nodes value
        */
        private class Node
        {

            public int value; // Represents the value conained in the node
            public Node left = null; // Represents the next node in the tree that is less than this.value
            public Node right = null; // Represetns the next node in the tree that is greater than this.value

            /*
                Takes in a number
                creates a new node with the value as number
                left and right are both set to null.
            */
            public Node(int number)
            {
                value = number;
                left = null;
                right = null;
            }
            /*
                Takes in a number, left hand side(less than), and right hand side(greater than);
                and creates a new node with the appropriate values;
            */
            public Node(int number, Node lhs, Node rhs)
            {
                value = number;
                left = lhs;
                right = rhs;
            }

            /*
            Copy Constructor
            */
            public Node(Node other)
            {
                value = other.value;
                left = other.left;
                right = other.right;
            }
        }
        // Represents the first Node in the tree
        private Node root = null;

        /*
            Returns True if the root of the tree is null. Indicating an empty tree
        */
        public bool empty()
        {
            return root.Equals(null);
        }

        /*
            Creates a new Node assigns it a value, and inserts it into the tree
        */
        public void addNode(int number)
        {
            Node currNode = root; // represents the current working Node;
            if (empty())
            {
                // Create A NEW node with number as its value
                // set the root to this node as it is the first to be created
                root = new Node(number);
            }
            else
            {
                // If value is greater than current node go the the right Until the Node is null, (Recursive step).
                // If value is less than current node go the the left until the Node is null(Recursive step).
            }
        }

        /*
            Prints to the console in sorted order, from least to greatest, the contents of the entire Tree.
        */
        public void printTree()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
