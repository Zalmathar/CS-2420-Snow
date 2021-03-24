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
        // Represents the number of elements inside of the tree
        private int size = 0;

        /*
            Returns True if the root of the tree is null. Indicating an empty tree
        */
        public bool empty()
        {
            return root == null;
        }

        /*
            Creates a new Node assigns it a value, and inserts it into the tree
        */
        public void addNode(int number)
        {
            if (empty())
            {
                // Create a new node with number as its value
                // set the root to this node as it is the first to be created
                root = new Node(number);
            }
            else
            {
                addNode(number, ref root);
            }
            size++;
        }

        // Adds a Node to the tree in a sorted order
        // If a node of equal value is added to the tree it will be placed as a child on the left side of the tree.
        private void addNode(int number, ref Node node)
        {
            // if number is equal to node.value. Insert a new node on the left hand side of the tree. 
            if (node.value.Equals(number))
            {
                Node newNode = new Node(number, node.left, null);
                node.left = newNode;
            }
            // If number is less than the node.value. Go to the left of the node. 
            if (node.value > number)
            {
                if (node.left == null)
                {
                    node.left = new Node(number);
                }
                else
                {
                    addNode(number, ref node.left);
                }
            }
            // If number is greater than the node.value. Go to ther right of the node.
            if (node.value < number)
            {
                if (node.right == null)
                {
                    node.right = new Node(number);
                }
                else
                {
                    addNode(number, ref node.right);
                }
            }
        }

        /*
            Prints to the console in sorted order, from least to greatest, the contents of the entire Tree.
        */
        public void printTree()
        {
            printTree(ref root);
        }

        private void printTree(ref Node node)
        {
            if (!this.empty())
            {
                if (node.left != null)
                {
                    printTree(ref node.left);
                }
                Console.WriteLine(node.value);
                if (node.right != null)
                {
                    printTree(ref node.right);
                }
            }
        }

        // Converts The entire tree into a sorted array.
        // Prints the tree into the array the same order as printTree does in console
        public int?[] toArray()
        {
            int?[] treeArray = new int?[size];
            toArray(ref root, ref treeArray);
            return treeArray;
        }

        private void toArray(ref Node node, ref int?[] arr)
        {
            if (!empty())
            {
                if (node.left != null)
                {
                    toArray(ref node.left, ref arr);
                }
                int i = 0;
                while (arr[i] != null)
                {
                    i++;
                }
                arr[i] = node.value;
                if (node.right != null)
                {
                    toArray(ref node.right, ref arr);
                }
            }
        }
    }
}