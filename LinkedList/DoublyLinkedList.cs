using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedList
{
    public class DoublyLinkedNode<T>
    {
        public T Data;
        public DoublyLinkedNode<T> Prev;
        public DoublyLinkedNode<T> Next;

        public DoublyLinkedNode(T data, DoublyLinkedNode<T> prev = null, DoublyLinkedNode<T> next = null)
        {
            Data = data;
            Prev = prev;
            Next = next;
        }
    }


    public class DoublyLinkedList<T>
    {
        private DoublyLinkedNode<T> head;
        private DoublyLinkedNode<T> tail;

        public void Add(DoublyLinkedNode<T> newNode)
        {
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                var current = head;

                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
                newNode.Prev = current;
                tail = newNode;
            }
        }

        public void AddAfter(DoublyLinkedNode<T> targetNode, DoublyLinkedNode<T> newNode)
        {
            if (head == null)
            {
                Console.WriteLine("존재하는 Node가 없습니다.");
                return;
            }

            var current = head;

            while (current != targetNode && current.Next != null)
            {
                current = current.Next;
            }

            if (tail == current)
            {
                newNode.Prev = tail;
                tail.Next = newNode;
                tail = newNode;

            }
            else
            {
                newNode.Prev = current;
                newNode.Next = current.Next;

                current.Next.Prev = newNode;
                current.Next = newNode;
            }
        }

        public void Remove(DoublyLinkedNode<T> targetNode)
        {
            if (head == null)
            {
                Console.WriteLine("존재하는 Node가 없습니다.");
                return;
            }

            var current = head;

            while (current != targetNode && current.Next != null)
            {
                current = current.Next;
            }

            if(head == current)
            {
                head = current.Next;
                head.Prev = null;
            }
            else
            {
                current.Prev = current.Next;
                current.Next.Prev = current.Prev;
                current = null;
            }
        }

        public DoublyLinkedNode<T> GetNode(int index)
        {

            if (head == null)
            {
                Console.WriteLine("Node가 존재하지않습니다.");
                return null;
            }

            var current = head;

            for (int i = 0; i < index; i++)
            {
                if(current.Next != null)
                {
                    current = current.Next;
                }
            }

            return current;
        }

        public int GetCount()
        {
            if(head == null)
            {
                return 0;
            }

            var current = head;
            int count = 1;

            while (current.Next != null)
            {
                current = current.Next;
                count++;
            }

            return count;
        }

    }
}
