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
            var postfix = "10 4 / 3 5 * +".Split(' ');

            var et = new ExpressionTree();
            et.Build(postfix);

            Console.Write("Inorder : ");
            et.Inorder(et.Root);
            Console.WriteLine();

            Console.Write("Postorder : ");
            et.Postorder(et.Root);
            Console.WriteLine();

            var result = et.Evaludate(et.Root);

            Console.WriteLine($"Result : {result}");
        }
    }
}
