using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListProgram list = new LinkedListProgram();
            list.Add(56);
            list.Add(70);
            list.Add(30);

            list.Search(30);




            //Console.WriteLine("\n--------------- Deleted firt node ---------");
            //Node nodes = list.DeleteFirstNode();
            //list.Display();

            //Console.WriteLine("\n--------------- Deleted Last node ---------");
            //Node node = list.DeleteLastNode();
            //list.Display();



        }
    }
}
