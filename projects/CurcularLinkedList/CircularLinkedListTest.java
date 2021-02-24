// Tanis Olesen
// 02/01/2021
// Uses assert statements to test the correct functionality of the CircularLinkedList class

public class CircularLinkedListTest {
    public static void main(String args[]) {
        // Test strings
        CircularLinkedList<String> myStringList = new CircularLinkedList<String>();
        myStringList.push_back("1");
        // Was pleased to the that the assert statment exist's in java
        assert (myStringList.front() == "1");
        assert (myStringList.back() == "1");
        myStringList.push_front("New First");
        assert (myStringList.front() == "New First");
        assert (myStringList.back() == "1");
        myStringList.push_back("New back");
        assert (myStringList.back() == "New back");
        assert (myStringList.front() == "New First");
        myStringList.pop_back();
        assert (myStringList.back() == "1");
        assert (myStringList.front() == "New First");
        myStringList.pop_front();
        assert (myStringList.back() == "1");
        assert (myStringList.front() == "1");
        myStringList.pop_back();
        assert (myStringList.empty());

        // Test Doubles
        CircularLinkedList<Double> myDoubleList = new CircularLinkedList<Double>();
        assert (myDoubleList.empty());
        myDoubleList.push_front(5.1);
        myDoubleList.push_front(4.2);
        myDoubleList.push_front(3.3);
        myDoubleList.push_front(2.4);
        myDoubleList.push_front(1.5);
        assert (myDoubleList.back() == 5.0);
        assert (myDoubleList.front() == 1.5);
        myDoubleList.pop_back();
        assert (myDoubleList.back() == 4.2);
        assert (myDoubleList.front() == 1.5);
        myDoubleList.pop_back();
        assert (!myDoubleList.empty());
        assert (myDoubleList.front() == 1.5);
        assert (myDoubleList.back() == 3.3);
        myDoubleList.pop_front();
        assert (myDoubleList.back() == 3.3);
        assert (myDoubleList.front() == 2.4);
        myDoubleList.pop_back();
        assert (myDoubleList.back() == 2.4);
        assert (myDoubleList.front() == 2.4);
        myDoubleList.pop_front();
        assert (myDoubleList.empty());

        // Test Integers
        CircularLinkedList<Integer> myIntList = new CircularLinkedList<Integer>();
        assert (myIntList.empty());
        myIntList.push_front(5);
        myIntList.push_front(4);
        myIntList.push_front(3);
        myIntList.push_front(2);
        myIntList.push_front(1);
        assert (myIntList.back() == 5);
        assert (myIntList.front() == 1);
        myIntList.pop_back();
        assert (myIntList.back() == 4);
        assert (myIntList.front() == 1);
        myIntList.pop_back();
        assert (!myIntList.empty());
        assert (myIntList.front() == 1);
        assert (myIntList.back() == 3);
        myIntList.pop_front();
        assert (myIntList.back() == 3);
        assert (myIntList.front() == 2);
        myIntList.pop_back();
        assert (myIntList.back() == 2);
        assert (myIntList.front() == 2);
        myIntList.pop_back();
        assert (myIntList.empty());
        System.out.println("All Tests Passed!");
    }
}
