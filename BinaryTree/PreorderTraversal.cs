using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinaryTree
{
    public class PreorderTraversal<T>
    {
        private BinaryNode<T> root;

        public PreorderTraversal(BinaryNode<T> tree)
        {
            root = tree;
        }

        public void ExecuteRecursive()
        {
            Preorder(root);
        }

        public void ExecuteStackIterator()
        {
            PreorderForStack();
        }

        private void PreorderForStack()
        {
            Stack<BinaryNode<T>> stack = new Stack<BinaryNode<T>>();

            stack.Push(root);

            while(stack.Count > 0)
            {
                var node = stack.Pop();

                if (node == null)
                {
                    continue;
                }
                
                Console.Write($"{node.Data} ");

                stack.Push(node.Right);
                stack.Push(node.Left);
            }
        }

        private void Preorder(BinaryNode<T> node)
        {
            if(node == null)
            {
                return;
            }

            // In node
            Console.Write($"{node.Data} ");
            // In Left Sub node
            Preorder(node.Left);
            // In Right Sub node
            Preorder(node.Right);
        }


    }
}
