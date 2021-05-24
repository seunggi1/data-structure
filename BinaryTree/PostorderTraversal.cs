using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinaryTree
{
    public class PostorderTraversal
    {
        private BinaryTree _tree;

        public PostorderTraversal(BinaryTree tree)
        {
            _tree = tree;
        }

        public void Execute()
        {
            Postorder(_tree.Root);

            Console.WriteLine();
        }

        public void ExecuteForIterator()
        {
            PostorderZZ();
        }

        private void Postorder(BinaryNode<string> node)
        {
            if(node == null)
            {
                return;
            }

            Postorder(node.Left);
            Postorder(node.Right);
            Console.Write($"{node.Data} ");
        }

        private void PostorderForIterator()
        {
            Stack<BinaryNode<string>> stack = new Stack<BinaryNode<string>>();

            var node = _tree.Root;

            // Leftmost 노드까지 오른쪽 자식노드와 루트를 스택에 저장
            while(node != null)
            {
                if(node.Right != null)
                {
                    stack.Push(node.Right);
                }

                stack.Push(node);
                node = node.Left;
            }
            
            while(stack.Count > 0)
            {
                node = stack.Pop();

                if(node.Right != null && stack.Count > 0 && node.Right == stack.Peek())
                {
                    // 오른쪽 자식 노드를 pop
                    var right = stack.Pop();
                    // 루트노드를 다시 Push

                    stack.Push(node);

                    node = right;


                    //Leftmost 노드까지 오른쪽 자식 노드와 루트를 스택에 저장
                    while(node != null)
                    {
                        if(node.Right != null)
                        {
                            stack.Push(node.Right);
                        }
                        stack.Push(node);
                        node = node.Left;
                    }
                } else
                {
                    Console.Write($"{node.Data} ");
                }
            }

        }

        private void PostorderZZ()
        {
            Stack<BinaryNode<string>> stack = new Stack<BinaryNode<string>>();

            var node = _tree.Root;

            while(node != null || stack.Count > 0)
            {
                
                while(node != null)
                {
                    if(node.Right != null)
                    {
                        stack.Push(node.Right);
                    }

                    stack.Push(node);

                    node = node.Left;
                }

                node = stack.Pop();

                if(node.Right != null && stack.Count > 0 && node.Right == stack.Peek())
                {
                    var right = stack.Pop();

                    stack.Push(node);

                    node = right;
                } else
                {
                    Console.Write($"{node.Data} ");

                    node = null;
                }
            
            }

        }

    }
}
