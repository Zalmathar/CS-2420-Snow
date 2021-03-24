// Tanis Olesen
// 03/22/2021

using System;

namespace MyBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBinaryTreeTest.runTests();

            MyBinaryTree tree = new MyBinaryTree();
            tree.addNode(1);
            tree.addNode(2);
            tree.addNode(3);
            tree.printTree();
        }
    }
}
