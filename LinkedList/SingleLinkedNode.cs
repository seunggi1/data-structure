using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedList
{
    public class SingleLinkedNode<T>
    {
        public T Data { get; set; }
        public SingleLinkedNode<T> Next { get; set; }

        public SingleLinkedNode(T data)
        {
            Data = data;
            Next = null;
        }
    }
}
