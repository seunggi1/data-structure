using DataStructure.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Queue
{
    public class LinkedListQueue
    {
        private SingleLinkedNode<object> Head { get; set; }
        private SingleLinkedNode<object> Tail { get; set; }

        public void Enqueue(object data)
        {
            if (Head == null)
            {
                Head = new SingleLinkedNode<object>(data);
                Tail = Head;
                return;
            }

            var newNode = new SingleLinkedNode<object>(data);
            Tail.Next = newNode;
            Tail = newNode;
        }

        public object Dequeue()
        {
            if (Head == null)
            {
                Console.WriteLine("Queue is empty");
                return null;
            }

            var result = Head.Data;
            Head = Head.Next;
/*
            if(Head == null)
            {
                Tail = null;
            }*/

            return result;
        }
    }
}
