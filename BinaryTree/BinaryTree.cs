using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinaryTree
{
    public class BinaryTree<T>
    { 
        public BinaryNode<T> Root { get; set; }

        public BinaryTree(T data)
        {
            Root = new BinaryNode<T>(data);
        }

        public void PreorderTraversal()
        {
            PreorderTraversal(Root);
        }

        private void PreorderTraversal(BinaryNode<T> node)
        {
            if(node == null)
            {
                return;
            }

            Console.WriteLine(node.Data);
            PreorderTraversal(node.Left);
            PreorderTraversal(node.Right);

        }

        public int GetDepth(BinaryNode<T> node)
        {
            // 노드가 아예 없는 빈 트리는 깊이가 -1, 루트 노드 하나만 있는 경우엔 깊이가 0이 된다. 
            if(node == null)
            {
                return -1;
            }

            return 1 + Math.Max(GetDepth(node.Left), GetDepth(node.Right));
        }

        // 노드의 최대 갯수 구하기
        public int GetCount(BinaryNode<T> node)
        {
            if(node == null)
            {
                return 0;
            }

            return 1 + GetCount(node.Left) + GetCount(node.Right);
        }

        public bool FindTreePath(BinaryNode<T> root, BinaryNode<T> target, List<BinaryNode<T>> path)
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

        public BinaryNode<T> LeastCommonAncestor(BinaryNode<T> root, BinaryNode<T> a, BinaryNode<T> b)
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
