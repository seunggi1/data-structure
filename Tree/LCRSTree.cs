using DataStructure.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Tree
{
    public class LCRSTree
    {
        public LCRSNode root;


        public LCRSTree(object data)
        {
            root = new LCRSNode(data);
        }

        public void AddChild(LCRSNode parentNode, object data)
        {
            if (parentNode == null)
            {
                return;
            }

            if (parentNode.LeftChild == null)
            {
                parentNode.LeftChild = new LCRSNode(data);
            }
            else
            {
                var currentNode = parentNode.LeftChild;

                while (currentNode.RightSibling != null)
                {
                    currentNode = currentNode.RightSibling;
                }

                currentNode.RightSibling = new LCRSNode(data);
            }
        }

        public void AddSibling(LCRSNode targetNode, object data)
        {
            if (targetNode == null)
            {
                return;
            }

            while (targetNode.RightSibling != null)
            {
                targetNode = targetNode.RightSibling;
            }

            targetNode.RightSibling = new LCRSNode(data);
        }

        public void PrintLevelOrder()
        {
            /*
             if (root == null)
            {
                Console.WriteLine("Root is empty");
                return;
            }

            int level = 1;
            var currentNode = root;
            Queue<LCRSNode> queue = new Queue<LCRSNode>();


            while (currentNode != null)
            {
                Console.Write($"({level}) {currentNode.Data} ");

                if (currentNode.LeftChild != null)
                {
                    queue.Enqueue(currentNode.LeftChild);
                }

                currentNode = currentNode.RightSibling;

                if (currentNode == null && queue.Count > 0)
                {
                    currentNode = queue.Dequeue();
                    Console.WriteLine();
                    level++;
                }
            }

        */

            var q = new Queue<LCRSNode>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                var node = q.Dequeue();

                while (node != null)
                {
                    Console.Write($"{node.Data} ");

                    if (node.LeftChild != null)
                    {
                        q.Enqueue(node.LeftChild);
                    }

                    node = node.RightSibling;
                }
                Console.WriteLine();
            }

        }

        public void PrintIndentTree()
        {
            PrintIndentTree(this.root, 1);
        }

        private void PrintIndentTree(LCRSNode node, int indent)
        {
            if(node == null)
            {
                return;
            }

            string pad = " ".PadLeft(indent);
            Console.WriteLine($"{pad}{node.Data}");

            // 왼쪽 자식 (자식이므로 Indent + 1)
            PrintIndentTree(node.LeftChild, indent + 1);

            // 오른쪽 형제 (형제이므로 기존 Indent 사용)
            PrintIndentTree(node.RightSibling, indent);
        }

        public void ExecuteTree()
        {
            var tree = new LCRSTree("A");


            for (int i = 1; i <= 5; i++)
            {
                tree.AddChild(tree.root, $"B{i}");
            }

            tree.AddChild(tree.root.LeftChild, $"C");

            for (int i = 10; i < 15; i++)
            {
                tree.AddSibling(tree.root.LeftChild.LeftChild, $"C{i}");
            }

            tree.PrintLevelOrder();



            tree.PrintIndentTree();
        }
    }
}
