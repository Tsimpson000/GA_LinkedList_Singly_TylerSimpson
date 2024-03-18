using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_LinkedList_Singly_TylerSimpson
{
    internal class LinkedList<T>
    {
        // Fields
        private LinkedListNode<T> head;
        private int count;

        // Property
        public int Count
        {
            get { return count; }
        }

        // Constructor
        public LinkedList()
        {
            head = null;
            count = 0;
        }

        // Method to add an element to the end of the linked list
        public void Add(T value)
        {
            // 1. Create a new node with the given value
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);

            // 2. Check if the linked list is empty by examining whether the 'head' reference is 'null'. If the list is empty, it means that there are no nodes in the list.

            if (head == null)
            {
                // 3. If the list is empty, make the new node ('newNode') the head of the list
                head = newNode;
            }
            else
            {
                // 4. If the list is not empty, start at the head
                LinkedListNode<T> current = head;

                // 5. Traverse the list to find the last node (one with no next node)
                while (current.Next != null)
                {
                    // 6. Move to the next node in the list
                    current = current.Next;
                }

                // 7. Connect the last node's 'Next' to the new node, adding it to the end
                current.Next = newNode;
            }

            // 8. Increase the count to keep track of the number of elements in the list
            count++;
        }

        // 1. Method to display all elements in the linked list
        public void Display()
        {
            // 2. Start at the head of the linked list
            LinkedListNode<T> current = head;

            // 3. Traverse the linked list and print each element
            while (current != null)
            {
                // 4. Print the current node's value followed by an arrow symbol
                Console.Write($"{current.Value} -> ");

                // 5. Move to the next node in the list
                current = current.Next;
            }

            // 6. Print "null" to indicate the end of the linked list
            Console.WriteLine("null");
        }

        // 1. Method to remove an element by its value
        public bool Remove(T value)
        {
            // 2. Check if the linked list is empty
            if (head == null)
            {
                // 3. If the list is empty, return false (Element not found)
                return false;
            }

            // 4. Check if the value to remove is at the head of the list
            if (head.Value.Equals(value))
            {
                // 5. If the value is at the head, update the head to the next node and decrease the count
                head = head.Next;
                count--;
                return true; // 6. Return true (Element found and removed)
            }

            // 7. If the value is not at the head, start at the head
            LinkedListNode<T> current = head;

            // 8. Traverse the list to find the element with the specified value
            while (current.Next != null)
            {
                // 9. Check if the value of the next node matches the specified value
                if (current.Next.Value.Equals(value))
                {
                    // 10. If a match is found, skip the next node by updating the 'Next' reference and decrease the count
                    current.Next = current.Next.Next;
                    count--;
                    return true; // 11. Return true (Element found and removed)
                }
                current = current.Next;
            }

            // 12. Return false (Element not found)
            return false;
        }

        public void Clear()
        {
            // Run until the stack is empty
            while (head != null)
            {
                // Store the reference to the next node
                LinkedListNode<T> nextNode = head.Next;

                // Remove the top node from the stack
                head = null;

                // Move to the next node
                head = nextNode;

                // Decrement the count
                count--;
            }
        }

        // 1. Indexer override to access elements by index
        public T this[int index]
        {
            get
            {
                // 2. Check if the provided index is out of range (negative or greater than or equal to the count of elements)
                if (index < 0 || index >= count)
                {
                    // 3. Throw an IndexOutOfRangeException if the index is out of range
                    throw new IndexOutOfRangeException();
                }

                // 4. Start at the head of the linked list
                LinkedListNode<T> current = head;

                // 5. Traverse the list to find the element at the specified index
                for (int i = 0; i < index; i++)
                {
                    // 6. Move to the next node in the list
                    current = current.Next;
                }

                // 7. Return the value of the element found at the specified index
                return current.Value;
            }
        }

        // This class is created INSIDE our linked list.
        // Inner class LinkedListNode<T> represents individual elements (nodes) in the linked list.
        class LinkedListNode<T>
        {
            // Represents the data stored in the node.
            public T Value { get; set; }

            // Represents the reference to the next node in the linked list.
            public LinkedListNode<T> Next { get; set; }

            // Constructor to initialize a LinkedListNode with a given value.
            public LinkedListNode(T value)
            {
                // Set the data value of the node.
                Value = value;
                // Initialize the reference to the next node as null.
                Next = null;
            }
        }
    }
}

