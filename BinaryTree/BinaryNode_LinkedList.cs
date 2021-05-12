using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinaryTree
{
    public class BinaryNode_LinkedList<T>
    {
        public T Data { get; set; }
        public BinaryNode_LinkedList<T> Left { get; set; }
        public BinaryNode_LinkedList<T> Right { get; set; }

        public BinaryNode_LinkedList(T data)
        {
            Data = data;
        }
    }
}
