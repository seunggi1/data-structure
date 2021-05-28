using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinaryTree
{
    public class InorderTraversal<T>
    {
        private BinaryTree<T> _tree;

        public InorderTraversal(BinaryTree<T> tree)
        {
            _tree = tree;
        }

        public void ExecuteRecursive()
        {
            Inorder(_tree.Root);
        }

        public void ExecuteIterator()
        {
            InorderForIterator();
        }

        private void Inorder(BinaryNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            Inorder(node.Left);
            Console.Write($"{node.Data} ");
            Inorder(node.Right);
        }

        private void InorderForIterator()
        {
            Stack<BinaryNode<T>> stack = new Stack<BinaryNode<T>>();

            var node = _tree.Root;


            while(node != null || stack.Count > 0)
            {
                while(node != null)
                {
                    stack.Push(node);

                    node = node.Left;
                }

                node = stack.Pop();

                Console.Write($"{node.Data} ");

                node = node.Right;
            }

/*
            // Leftmost 노드까지 스택에 저장
            while (node != null)
            {
                stack.Push(node);

                node = node.Left;
            }

            while(stack.Count > 0)
            {
                node = stack.Pop();

                Console.Write($"{node.Data} ");

                if(node.Right != null)
                {
                    node = node.Right;
                    
                    while(node != null)
                    {
                        stack.Push(node);
                        node = node.Left;
                    }
                }

            }*/
        }
    }
}
