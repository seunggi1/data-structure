using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinaryTree
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {

        private class Node<P>
        {
            public P Data { get; set; }
            public Node<P> Left { get; set; }
            public Node<P> Right { get; set; }

            public Node(P data)
            {
                this.Data = data;
            }
        }

        private Node<T> root;

        public void Add(T data)
        {
            if (root == null)
            {
                root = new Node<T>(data);
                return;
            }

            var node = root;

            while (node != null)
            {
                /*
                  비교 인스턴스 보다 높으면 0 보다 높은 값 
                  비교 인스턴스 보다 낮으면 0 보다 낮은 값 
                  비교 인스턴스와 같으면 0 반환!
                 */
                int cmp = data.CompareTo(node.Data);

                if (cmp == 0)
                {
                    Console.WriteLine("Duplicate");
                }
                else if (cmp < 0)
                {
                    if (node.Left == null)
                    {
                        node.Left = new Node<T>(data);
                        break;
                    }
                    else
                    {
                        node = node.Left;
                    }
                }
                else
                {
                    if (node.Right == null)
                    {
                        node.Right = new Node<T>(data);
                        break;
                    }
                    else
                    {
                        node = node.Right;
                    }
                }
            }
        }

        public bool Search(T data)
        {
            if (root == null)
            {
                return false;
            }

            var node = root;

            while (node != null)
            {

                int cmp = data.CompareTo(node.Data);

                if (cmp == 0)
                {
                    return true;
                }
                else if (cmp < 0)
                {
                    node = node.Left;
                }
                else
                {
                    node = node.Right;
                }
            }

            return false;
        }

        public bool SearchRecursive(T data)
        {
            return SearchRecursive(root, data);
        }

        private bool SearchRecursive(Node<T> node, T data)
        {
            if (node == null)
            {
                return false;
            }

            int cmp = node.Data.CompareTo(data);

            if (cmp == 0)
            {
                return true;
            }
            else if (cmp < 0)
            {
                return SearchRecursive(node.Left, data);
            }
            else if (cmp > 0)
            {
                return SearchRecursive(node.Right, data);
            }

            return false;
        }

        public bool Remove(T data)
        {
            if (root == null)
            {
                return false;
            }

            var node = root;
            Node<T> prev = null;

            while (node != null)
            {
                int cmp = data.CompareTo(node.Data);

                if (cmp == 0)
                {
                    break;
                }
                else if (cmp < 0)
                {
                    prev = node;
                    node = node.Left;
                }
                else if (cmp > 0)
                {
                    prev = node;
                    node = node.Right;
                }
            }

            if (node == null)
            {
                return false;
            }

            if (prev == null)
            {
                node = null;

                return true;
            }

            if (node.Left == null && node.Right == null)
            {
                if (prev.Left == node)
                {
                    prev.Left = null;
                }
                else if (prev.Right == node)
                {
                    prev.Right = null;
                }

                node = null;
            }
            else if (node.Left == null || node.Right == null)
            {
                if (prev.Left == node)
                {
                    if (node.Left != null)
                    {
                        prev.Left = node.Left;
                    }
                    else
                    {
                        prev.Left = node.Right;
                    }

                }
                else if (prev.Right == node)
                {
                    if (node.Left != null)
                    {
                        prev.Right = node.Left;
                    }
                    else
                    {
                        prev.Right = node.Right;
                    }

                    node = null;
                }
            }
            else
            {
                var pre = node;
                var min = node.Right;

                while (min.Left != null)
                {
                    pre = min;
                    min = min.Left;
                }

                // min 노드 값으로 대치
                node.Data = min.Data;

                if (pre.Left == min)
                {
                    pre.Left = min.Right;
                }
                else
                {
                    pre.Right = min.Right;
                }
            }

            return true;
        }

        public T[] TreeToArray()
        {
            int count = 0;
            T[] array = new T[2];

            TreeToArray(ref array, ref count, root);

            return array;
        }

        private void TreeToArray(ref T[] array, ref int count, Node<T> node)
        {
            if (node == null)
            {
                return;
            }

            TreeToArray(ref array, ref count, node.Left);

            if (array.Length <= count)
            {
                System.Array.Resize(ref array, array.Length + 1);
            }

            array[count++] = node.Data;
            TreeToArray(ref array, ref count, node.Right);
        }

        public void GetKthDownNumber(int number)
        {
            int count = 0;

            GetKthSmalllest(number, ref count, root);
        }

        private bool GetKthSmalllest(int number, ref int count, Node<T> node)
        {
            if(node == null)
            {
                return false;
            }

            bool found = GetKthSmalllest(number, ref count, node.Left);

            if(found)
            {
                return true;
            }
            
            if(number == ++count)
            {
                Console.WriteLine(node.Data);
                return true;
            }

            return GetKthSmalllest(number, ref count, node.Right);
        }

        public void FindKthLargest(int number)
        {
            int count = 0;

             FindKthLargest(number, ref count, root);
        }

        private bool FindKthLargest(int number, ref int count, Node<T> node)
        {
            if(node == null)
            {
                return false;
            }

            bool found = FindKthLargest(number, ref count, node.Right);

            if(found)
            {
                return true;
            }

            count++;
            if(number == count)
            {
                Console.WriteLine( $"{number} largest : {node.Data}");
            }

            return FindKthLargest(number, ref count, node.Left);
        }


        public void LeastCommonAncestor(T a, T b)
        {
            var lca = LeastCommonAncestor(a, b, root);

            if(lca != null)
            {
                Console.WriteLine(lca.Data);
            }

            lca = LeastCommonAncestorIterator(a, b, root);

            if (lca != null)
            {
                Console.WriteLine($"Iterator : " + lca.Data);
            }
        }

        private Node<T> LeastCommonAncestor(T a, T b, Node<T> node)
        {
            if(node == null)
            {
                return null;
            }

            if (a.CompareTo(node.Data) < 0 && b.CompareTo(node.Data) < 0)
            {
                return LeastCommonAncestor(a, b, node.Left);
            }
            else if (a.CompareTo(node.Data) > 0 && b.CompareTo(node.Data) > 0)
            {
                return LeastCommonAncestor(a, b, node.Right);
            }

            return node;
        }

        private Node<T> LeastCommonAncestorIterator(T a, T b, Node<T> node)
        {
            if (node == null)
            {
                return null;
            }

            while (node != null)
            {
                if (a.CompareTo(node.Data) < 0 && b.CompareTo(node.Data) < 0)
                {
                    node = node.Left;
                }
                else if (a.CompareTo(node.Data) > 0 && b.CompareTo(node.Data) > 0)
                {
                    node = node.Right;
                }
                else
                {
                    break;
                }
            }

            return node;
        }

        public BinaryNode<T> binaryTreeToBST(BinaryNode<T> node)
        {
            List<T> sortList = new List<T>();

            ExtractKeys(node, sortList);

            sortList.Sort();

            int count = 0;
            ReplaceKeys(node, sortList, ref count);

            return node;
        }

        private static void ExtractKeys(BinaryNode<T> node, List<T> sortList)
        {
            if(node == null)
            {
                return;
            }

            ExtractKeys(node.Left, sortList);
            sortList.Add(node.Data);
            ExtractKeys(node.Right, sortList);
        }

        private static void ReplaceKeys(BinaryNode<T> node, List<T> sortList, ref int count)
        {
            if(node == null)
            {
                return;
            }

            ReplaceKeys(node.Left, sortList, ref count);
            node.Data = sortList[count++];
            ReplaceKeys(node.Right, sortList, ref count);
        }
    }
}
