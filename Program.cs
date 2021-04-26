using System;
using DataStructure.Array;
using DataStructure.LinkedList;
using DataStructure.Queue;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
           var queue = new ArrayQueue();

            for (int i = 0; i < 20; i++)
            {
                queue.Enqueue(i);
            }

            queue.Dequeue();

            queue.Enqueue(566);
        }
    }
}
