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
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;

                while (temp.next != null)
                {
                    temp = temp.next;
                }
                if (node.data != 30)
                {
                    temp.next = node;
                }
                if (node.data == 30)
                {
                    Node bet = node;
                    bet.next = temp;
                    head.next = bet;
                }
            }
        }


        internal Node DeleteFirstNode()
        {
            if (head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return head;

        }
        internal Node DeleteLastNode()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Node temp = head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;
            return head;
        }


        internal void Display()
        {
            Node temp = head;
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

        internal Node Search(int data)
        {
            while (head != null)
            {
                if (head.data == data)
                {
                    return this.head;
                }
                this.head = this.head.next;

            }
            return null;
        }
    }


}


