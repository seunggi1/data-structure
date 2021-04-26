using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedList
{
    public class DoublyCircularLinkedList<T>
    {
        private DoublyLinkedNode<T> Head { get; set; }

        public void Add(DoublyLinkedNode<T> newNode)
        {
            if (Head == null)
            {
                Head = newNode;
                Head.Prev = Head;
                Head.Next = Head;
            }
            else
            {
                var tail = Head.Prev;

                Head.Prev = newNode;
                tail.Next = newNode;
                newNode.Prev = tail;
                newNode.Next = Head;
            }
        }

        public void AddAfter(DoublyLinkedNode<T> current, DoublyLinkedNode<T> newNode)
        {
            if (Head == null || current == null || newNode == null)
            {
                throw new InvalidOperationException();
            }

            newNode.Next = current.Next;
            current.Next.Prev = newNode;
            newNode.Prev = current;
            current.Next = newNode;
        }

        public void Remove(DoublyLinkedNode<T> removeNode)
        {
            if (Head == null || removeNode == null)
            {
                throw new InvalidOperationException();
            }

            if (Head == removeNode && Head == Head.Next)
            {
                Head = null;

            }
            else
            {
                removeNode.Next.Prev = removeNode.Prev;
                removeNode.Prev.Next = removeNode.Next;

                removeNode = null;
            }

            removeNode = null;
        }

        public DoublyLinkedNode<T> GetNode(int index)
        {
            if (Head == null)
            {
                throw new InvalidOperationException();
            }

            int count = 0;
            var current = Head;

            while (count < index)
            {
                count++;
                current = current.Next;

                if (current == Head)
                {
                    return null;
                }
            }

            return current;
        }

        public int GetCount()
        {
            int count = 0;
            var current = Head;

            while (current != null)
            {
                count++;

                if (current.Next == Head)
                {
                    break;
                }

                current = current.Next;
            }

            return count;
        }

        public static bool IsCircularLinkedList(DoublyCircularLinkedList<T> linkedList)
        {
            var head = linkedList.GetNode(0);
            var current = head;

            // 빈 리스트는 원형리스트이다.
            if (head == null)
            {
                return true;
            }

            while (current != null)
            {
                current = current.Next;

                if (current == head)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsCyclic(DoublyLinkedNode<T> node)
        {
            var p1 = node;
            var p2 = node;

            while (p1 != null && p2 != null)
            {
                p1 = p1.Next;
                p2 = p2.Next;

                if(p1 == null || p2 == null)
                {
                    break;
                }

                p2 = p2.Next;

                if(p1 == p2)
                {
                    return true;
                }

            }

            return false;
        }

    }
}
