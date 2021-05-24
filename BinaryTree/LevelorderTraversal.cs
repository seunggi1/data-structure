using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinaryTree
{
    public class LevelorderTraversal
    {
        public BinaryTree _tree;

        public LevelorderTraversal(BinaryTree tree)
        {
            _tree = tree;
        }

        public void Execute()
        {
            LevelorderForQueue();
        }

        private void LevelorderForQueue()
        {
            Queue<BinaryNode<string>> queue = new Queue<BinaryNode<string>>();

            queue.Enqueue(_tree.Root);
            queue.Enqueue(null);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                if(node == null)
                {
                    if(queue.Count > 0)
                    {
                        queue.Enqueue(null);
                    }

                    Console.WriteLine();
                    continue;
                }

                Console.Write($"{node.Data} ");

                if(node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }

                if(node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }

            }
            
        }
    }
}
