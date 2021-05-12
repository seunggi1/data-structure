using System;
using DataStructure.Array;
using DataStructure.BinaryTree;
using DataStructure.LinkedList;
using DataStructure.Queue;
using DataStructure.Stack;
using DataStructure.Tree;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTree_Array();

            tree.Root = "A";
            tree.SetLeft(0, "B");
            tree.SetRight(0, "C");

            tree.SetLeft(1, "D");
            tree.SetLeft(2, "F");

            tree.PrintTree();

            var data = tree.GetParent(5);

            Console.WriteLine(data);

            Console.WriteLine(tree.GetLeft(2));
        }
    }
}
