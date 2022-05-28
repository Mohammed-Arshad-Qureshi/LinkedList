using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.LinkedList<int> linked = new System.Collections.Generic.LinkedList<int>();
            linked.AddFirst(56);
            linked.AddLast(30);
            linked.AddLast(70);
            
            foreach(var element in linked)
            {
                Console.WriteLine(element);
            }    

            
        }
    }
}
