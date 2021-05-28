using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinaryTree
{
    public class LevelorderTraversal<T>
    {
        public BinaryTree<T> _tree;

        public LevelorderTraversal(BinaryTree<T> tree)
        {
            _tree = tree;
        }

        public void Execute()
        {
            LevelorderForQueue();
        }

        private void LevelorderForQueue()
        {
            Queue<BinaryNode<T>> queue = new Queue<BinaryNode<T>>();

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
