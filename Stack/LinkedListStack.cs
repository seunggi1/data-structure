using DataStructure.LinkedList;
using System;

namespace DataStructure.Stack
{
    public class LinkedListStack
    {
        private SingleLinkedNode<object> top;
        private bool IsEmpty { get { return top == null; } }

        public void Push(object data)
        {
            if(IsEmpty)
            {
                top = new SingleLinkedNode<object>(data);

                return;
            }

            var newNode = new SingleLinkedNode<object>(data);
            newNode.Next = top;
            top = newNode;
        }

        public object Pop()
        {
            if(IsEmpty)
            {
                Console.WriteLine("Stack is empty");
                return null;
            }

            object result = top.Data;
            top = top.Next;
            return result;
        }

        public object Peek()
        {
            if(IsEmpty)
            {
                Console.WriteLine("Stack is empty");
                return null;
            }

            return top.Data;
        }

    }
}
