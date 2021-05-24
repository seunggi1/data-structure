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

        public int GetDepth(BinaryNode<string> node)
        {
            // 노드가 아예 없는 빈 트리는 깊이가 -1, 루트 노드 하나만 있는 경우엔 깊이가 0이 된다. 
            if(node == null)
            {
                return -1;
            }

            return 1 + Math.Max(GetDepth(node.Left), GetDepth(node.Right));
        }

        // 노드의 최대 갯수 구하기
        public int GetCount(BinaryNode<string> node)
        {
            if(node == null)
            {
                return 0;
            }

            return 1 + GetCount(node.Left) + GetCount(node.Right);
        }

        public bool FindTreePath(BinaryNode<string> root, BinaryNode<string> target, List<BinaryNode<string>> path)
        {
            if(root == null)
            {
                return false;
            }

            path.Add(root);

            if(root == target)
            {
                return true;
            }

            if(FindTreePath(root.Left, target, path) || FindTreePath(root.Left, target, path))
            {
                return true;
            }

            path.RemoveAt(path.Count - 1);
            return false;
        }

        public BinaryNode<string> LeastCommonAncestor(BinaryNode<string> root, BinaryNode<string> a, BinaryNode<string> b)
        {
            if (root == null)
            {
                return null;
            }

            if (root == a || root == b)
            {
                return root;
            }

            var left = LeastCommonAncestor(root.Left, a, b);
            var right = LeastCommonAncestor(root.Right, a, b);

            if (left != null && right != null)
            {
                return root;
            }
            else
            {
                return (left != null) ? left : right;
            }
        }
    }
}
