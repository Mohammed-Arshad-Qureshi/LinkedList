using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedListProgram
    {
        internal Node head;
        internal void Add(int data)
        {
            Console.WriteLine(data + " first created in Linked list");
            if(head == null)
            {
                head = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = head;
                head = temp;
            }
            
        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
