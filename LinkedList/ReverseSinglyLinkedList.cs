using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedList
{
    public class ReverseSinglyLinkedList<T>
    {
        private SingleLinkedNode<T> Head { get; set; }

        public void Add(SingleLinkedNode<T> newNode)
        {
            if(Head == null)
            {
                Head = newNode;
                Head.Next = Head;
            } else
            {
                newNode.Next = Head.Next;
                Head.Next = newNode;
                Head = newNode;
            }

        }

        public void AddAfter(SingleLinkedNode<T> current, SingleLinkedNode<T> newNode)
        {
            if(Head == null || current == null || newNode == null)
            {
                throw new InvalidOperationException();
            }

            if(current == Head)
            {
                newNode.Next = Head.Next;
                Head.Next = newNode;
                Head = newNode;
            } else
            {
                newNode.Next = current.Next;
                current.Next = newNode;
            }
        }

        public SingleLinkedNode<T> GetNode(int index)
        {
            if(Head == null)
            {
                return null;
            }

            int count = 0;
            var current = Head.Next;

            while (count < index)
            {
                count++;
                current = current.Next;

                if(count != index && current == Head)
                {
                    return null;
                }
            }

            return current;
        }

        public int GetCount()
        {
            if(Head == null)
            {
                return 0;
            }

            int count = 0;
            var current = Head;

            while(current != null)
            {
                count++;
                current = current.Next;
                if(current == Head)
                {
                    break;
                }
            }

            return count;
        }

    }
}
