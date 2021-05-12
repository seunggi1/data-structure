using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinaryTree
{
    public class BinaryTree_LinkedList
    { 
        private BinaryNode_LinkedList<string> Root { get; set; }

        public BinaryTree_LinkedList(string data)
        {
            Root = new BinaryNode_LinkedList<string>(data);
        }

        public void PreorderTraversal()
        {
            PreorderTraversal(Root);
        }

        private void PreorderTraversal(BinaryNode_LinkedList<string> node)
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
