using System;
using System.Collections;
using DataStructure.Array;
using DataStructure.BinaryTree;
using DataStructure.LinkedList;
using DataStructure.Queue;
using DataStructure.Stack;
using DataStructure.Tree;
using DataStructure.Heap;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            var heap = new MinHeap();

            // 힙 속성을 따르는 값
            heap.Add(50);
            heap.Add(10);
            heap.Add(22);
            heap.Add(12);
            heap.Add(34);

            // 힙 속성을 따르지않는 값
            heap.Add(53);
            heap.Add(85);

            Console.WriteLine($"{heap.Remove()}");
            Console.WriteLine($"{heap.Remove()}");

            heap.DebugDisplayHeap();
        }
    }
}
