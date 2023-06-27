using System;
using System.Collections.Generic;

namespace LinkedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            LinkedList<double> list = new LinkedList<double>();
            list.AddLast(-2.5);
            list.AddLast(-1.0);
            list.AddLast(3.5);
            list.AddLast(2.0);
            list.AddLast(1.0);

            
            LinkedListNode<double> node = list.First;
            while (node != null && node.Value <= 0)
            {
                node = node.Next;
            }
            if (node != null && node != list.First)
            {
                list.Remove(node.Previous);
            }

            
            foreach (var item in list)
            {
                Console.Write("{0} ", item);
            }
            Console.ReadKey();
        }
    }
}