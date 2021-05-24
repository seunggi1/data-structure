using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinaryTree
{
    public class BinaryTraversal<T>
    {
        public void PreorderTraversal(BinaryNode<T> node)
        {
            if(node == null)
            {
                return;
            }

            Console.Write($"{node.Data} ");

            PreorderTraversal(node.Left);
            PreorderTraversal(node.Right);
        }

        public void InorderTraversal(BinaryNode<T> node)
        {
            if(node == null)
            {
                return;
            }

            InorderTraversal(node.Left);
            Console.Write($"{node.Data} ");
            InorderTraversal(node.Right);

        }

        public void PostorderTraversal(BinaryNode<T> node)
        {
            if(node == null)
            {
                return;
            }

            PostorderTraversal(node.Left);
            PostorderTraversal(node.Right);

            Console.Write($"{node.Data} ");
        }

        public void LevelorderTraversal(BinaryNode<T> node)
        {
            if(node == null)
            {
                return;
            }

            Console.Write($"{node.Data} ");
            
        }

    }
}
