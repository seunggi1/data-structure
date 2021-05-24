using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinaryTree
{
    public class BinaryTree
    { 
        public BinaryNode<string> Root { get; set; }

        public BinaryTree(string data)
        {
            Root = new BinaryNode<string>(data);
        }

        public void PreorderTraversal()
        {
            PreorderTraversal(Root);
        }

        private void PreorderTraversal(BinaryNode<string> node)
        {
            if(node == null)
            {
                return;
            }

            Console.WriteLine(node.Data);
            PreorderTraversal(node.Left);
            PreorderTraversal(node.Right);

        }

    }
}
