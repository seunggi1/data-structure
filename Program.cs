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
            var tree = new BinaryTree.BinaryTree("A");

            tree.Root.Left = new BinaryNode<string>("B");
            tree.Root.Left.Left = new BinaryNode<string>("C");
            tree.Root.Left.Right = new BinaryNode<string>("D");

            tree.Root.Left.Right.Left = new BinaryNode<string>("D1");
            tree.Root.Left.Right.Right = new BinaryNode<string>("D2");

            tree.Root.Right = new BinaryNode<string>("E");
            tree.Root.Right.Left = new BinaryNode<string>("F");
            tree.Root.Right.Right = new BinaryNode<string>("G");

            Console.WriteLine(tree.GetCount(tree.Root));
            Console.WriteLine(tree.GetDepth(tree.Root));
            Console.WriteLine(tree.LeastCommonAncestor(tree.Root, tree.Root.Left.Right.Right, tree.Root.Left.Left).Data);
        }
    }
}
