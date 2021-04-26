using DataStructure.LinkedList;
using System;

namespace DataStructure.LinkedList
{
    public class SinglyCircularLinkedList<T>
    {
        public SingleLinkedNode<T> head { get; set; }

        public SinglyCircularLinkedList()
        {

        }

        public SinglyCircularLinkedList(T data)
        {
            head = new SingleLinkedNode<T>(data);
            head.Next = head;
        }

        public void Add(SingleLinkedNode<T> newNode)
        {
            if (head == null)
            {
                head = newNode;
                head.Next = head;
            }
            else
            {
                var current = head;

                while (current != null && current.Next != head)
                {
                    current = current.Next;
                }

                newNode.Next = current.Next;
                current.Next = newNode;
            }
        }

        public void AddAfter(SingleLinkedNode<T> current, SingleLinkedNode<T> newNode)
        {
            if (head == null || current == null || newNode == null)
            {
                throw new InvalidOperationException();
            }

            newNode.Next = current.Next;
            current.Next = newNode;

        }

        public void Remove(SingleLinkedNode<T> removeNode)
        {
            if (head == null || removeNode == null)
            {
                throw new InvalidOperationException();
            }

            if (head == removeNode)
            {
                head = head.Next;
            }
            else
            {
                var current = head;

                while (current.Next != removeNode)
                {
                    current = current.Next;
                }

                current.Next = current.Next.Next;
                removeNode = null;
            }
        }

        public SingleLinkedNode<T> GetNode(int index)
        {
            if(head == null || index > GetCount() - 1)
            {
                throw new InvalidOperationException();
            }

            var current = head;

            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            return current;
        }

        public int GetCount()
        {
            int count = 0;
            var current = head;

            while(current != null)
            {
                count++;
                current = current.Next;

                if(current == head)
                {
                    break;
                }
            }

            return count;
        }

    }
}
