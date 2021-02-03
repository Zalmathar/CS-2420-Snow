// Tanis Olesen
// 02/01/2021
// Implements a circularly linked list

// Used this fourm to understand generic Types in java https://www.quora.com/What-does-T-means-in-java?share=1
public class CircularLinkedList<T> {
    // Represents a Node in a linked list
    private class Node {
        T data;  // Holds the data
        Node next; // represents the next Node in the circular linked list
    }
    // Represents a pointer to the last node in the list
    Node back;

    // Constructor
    public CircularLinkedList() {
        
    }

    // empty(), returns true if the list is empty
    public boolean empty() {
        return back == null;
    }

    // Last pointer in the list points to the front of the list
    // pop_back(), removes the last node in the list
    public void pop_back() {
        // find the item before the back, requires you to iterate through the entire list to find.
        Node iterator = back.next;
        while (iterator.next != back) {
            iterator = iterator.next;
        }
        iterator.next = back.next;
        back.next = null;
        back = iterator;
    }

    // pop_front, removes the first node in the list
    public void pop_front() {
        Node newFront = back.next.next;
        Node oldFront = back.next;
        back.next = newFront;
        oldFront.next = null;
    }

    //  push_front, adds a node to the front of the list
    public void push_front(T value) {
        if (!empty()) {
            Node newNode = new Node();
            Node oldFront = back.next;
            newNode.data = value;
            newNode.next = oldFront;
            back.next = newNode;
        } else {
            Node newNode = new Node();
            newNode.data = value;
            newNode.next = newNode;
            back = newNode;
        }
    }

    // push_back, adds a node to the back of the list
    public void push_back(T value) {
        if (!empty()) {
            Node newNode = new Node();
            newNode.data = value;
            newNode.next = back.next;
            back.next = newNode;
            back = newNode;
        } else {
            Node newNode = new Node();
            newNode.data = value;
            newNode.next = newNode;
            back = newNode;
        }
    }

    //  front() returns a reference to the front of the list
    public T front() {
        return back.next.data;
    }
    
    //  back() returns a reference to the back of the list
    public T back() {
        return back.data;
    }
}