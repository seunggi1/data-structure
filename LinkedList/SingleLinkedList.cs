using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedList
{
    public class SingleLinkedList<T>
    {
        private SingleLinkedNode<T> head;

        public void Add(SingleLinkedNode<T> newNode)
        {
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                SingleLinkedNode<T> current = head;

                // current != null 조건이 없어도 되ㅣㅣ
                while (current != null && current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }

        public void AddAfter(int number, SingleLinkedNode<T> newNode)
        {
            if (head == null || number > GetCount())
            {
                return;
            }

            SingleLinkedNode<T> current = head;
            SingleLinkedNode<T> prevNode = null;

            for (int i = 1; i < number; i++)
            {
                prevNode = current;
                current = current.Next;
            }

            if (prevNode == null)
            {
                newNode.Next = current;
                head = newNode;
            }
            else
            {
                newNode.Next = current.Next;
                current.Next = newNode;
            }
        }

        public SingleLinkedNode<T> GetNode(int nodeNumber)
        {
            if (head == null && nodeNumber > GetCount())
            {
                throw new NullReferenceException("존재 하지않는 노드입니다.");
            }

            SingleLinkedNode<T> resultNode = head;

            for (int i = 1; i < nodeNumber; i++)
            {
                if (head.Next != null)
                {
                    resultNode = resultNode.Next;
                }
            }

            return resultNode;
        }

        public void Remove(SingleLinkedNode<T> removeNode)
        {
            if (removeNode == null && head == null)
            {
                throw new NullReferenceException();
            }

            SingleLinkedNode<T> current = head;
            SingleLinkedNode<T> prevNode = null;

            while (current != removeNode && current.Next != null)
            {
                prevNode = current;
                current = current.Next;
            }

            // 첫번재 노드 삭제 시
            if (prevNode == null)
            {
                head = head.Next;
            }
            else
            {
                prevNode.Next = current.Next;
            }

            current = null;
        }

        private int GetCount()
        {
            if (head == null)
            {
                return 0;
            }

            int count = 1;
            SingleLinkedNode<T> current = head;
            while (current != null && current.Next != null)
            {
                current = current.Next;
                count++;
            }

            return count;
        }
    }
}
