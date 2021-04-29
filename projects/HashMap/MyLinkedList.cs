// Tanis Olesen
// 04/28/2021
// Got fustrated with the System.Collections.Generic implementaion of a Linked list when debugging. So i made my own quick implementaion for debugging purposes.

namespace LinkedList
{
    class MyLinkedList<T>
    {
        public class Node
        {
            public T data;
            public Node next;

            public Node(T data)
            {
                this.data = data;
            }
        }
        private Node head;
        public MyLinkedList()
        {

        }

        public void AddLast(T data)
        {
            if (head == null)
            {
                head = new Node(data);
            }
            else
            {
                Node iter = head;
                while (iter.next != null)
                {
                    iter = iter.next;
                }
                iter.next = new Node(data);
            }
        }

        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            var node = head;
            while (node != null)
            {
                yield return node.data;
                node = node.next;
            }
        }
    }
}