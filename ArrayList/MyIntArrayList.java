public class MyIntArrayList {
    int size;
    int capacity;
    int[] array; // the brackets go to the type

    // Constuctor
    public MyIntArrayList() {
        size = 0;
        capacity = 10;
        array = new int[capacity];
    }

    public void add(int value) {
        if (size > capacity) {
            int[] newArray = new int[capacity * 2];
            for (int i = 0; i < size; i++) {
                newArray[i] = array[i];
            }
            array = newArray;
        }
        array[size] = value;
        size++;
    }

    public void popBack(int value) {
        array[size] = null;
        size--;
    }
}