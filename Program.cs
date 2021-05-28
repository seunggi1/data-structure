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
            var bst = new BinarySearchTree<int>();

            bst.Add(6);
            bst.Add(7);
            bst.Add(2);
            bst.Add(1);
            bst.Add(5);
            bst.Add(3);
            bst.Add(4);

            bst.FindKthLargest(6);


            bst.LeastCommonAncestor(1, 4);

            var root = new BinaryNode<int>(3);
            root.Left = new BinaryNode<int>(5);
            root.Left.Left = new BinaryNode<int>(7);
            root.Left.Right = new BinaryNode<int>(6);
            root.Right = new BinaryNode<int>(9);
            root.Right.Right = new BinaryNode<int>(8);

            var tree = bst.binaryTreeToBST(root);
        }
    }
}
