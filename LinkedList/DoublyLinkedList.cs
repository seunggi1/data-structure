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

                while (current != null && current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
                newNode.Prev = current;
                tail = newNode;
            }
        }

        public void AddAfter(DoublyLinkedNode<T> current, DoublyLinkedNode<T> newNode)
        {
            if (head == null || current == null || newNode == null)
            {
                Console.WriteLine("존재하는 Node가 없습니다.");
                return;
            }

            if (current == tail)
            {
                tail = newNode;
            }

            current.Next.Prev = newNode;
            newNode.Next = current.Next;
            newNode.Prev = current;
            current.Next = newNode;
        }

        public void Remove(DoublyLinkedNode<T> removeNode)
        {
            if (head == null || removeNode == null)
            {
                Console.WriteLine("존재하는 Node가 없습니다.");
                return;
            }

            if (head == removeNode)
            {
                head = removeNode.Next;

                if (head != null)
                {
                    head.Prev = null;
                }
            } else if(tail == removeNode)
            {
                tail = removeNode.Prev;
            }
            else
            {
                removeNode.Prev.Next = removeNode.Next;

                if (removeNode.Next != null)
                {
                    removeNode.Next.Prev = removeNode.Prev;
                }

                removeNode = null;
            }
        }

        public DoublyLinkedNode<T> GetNode(int index)
        {
            var current = head;

            for (int i = 0; i < index && current != null; i++)
            {
                current = current.Next;
            }

            return current;
        }

        public int GetCount()
        {
            int count = 0;
            var current = head;
            
            while (current != null)
            {
                current = current.Next;
                count++;
            }

            return count;
        }

    }
}
