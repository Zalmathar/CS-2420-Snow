// Tanis olesen 03/17/2021
// Lecture Notes and follow along

class Tree {
    /*
        Represents a Node inside of a binary tree
    */
    public class Node {
        int num;
        Node left;
        Node right;

        public String toString() {
            return String.valueOf(num);
        }
    }
    // Represents the First Node in the tree
    public Node root;

    // Traverses the tree and prits all elements to the console
    public void climb(Node node) {
        if (node.left != null) {
            climb(node.left);
        }
        System.out.println();
        if (node.right != null) {
            climb(node.right);
        }
    }
    public static void main(String[] args) {
        climb(root);
    }
}