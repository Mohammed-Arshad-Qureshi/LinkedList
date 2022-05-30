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
            Node node = new Node(data);
            if(head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
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
