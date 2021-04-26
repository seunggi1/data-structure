using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Queue
{
    public class ArrayQueue
    {
        private object[] queue;        
        private int front;
        private int rear;

        public ArrayQueue()
        {
            queue = new object[20];

            front = -1;
            rear = -1;
        }

        public void Enqueue(object data)
        {
            if((rear + 1) % queue.Length == front)
            {
                Console.WriteLine("배열이 가득 찼습니다.");
            } else
            {
                if(front == -1)
                {
                    front++;
                }

                rear = (rear + 1) % queue.Length;

                queue[rear] = data;
            }
            
        }

        public object Dequeue()
        {
            if(front == -1 && rear == -1)
            {
                return null;
            }
            
            object result = queue[front];
            queue[front] = null;

            if (front == rear)
            {
                front = -1;
                rear = -1;
            } else
            {
                front = (front + 1) % queue.Length;
            }
         
            return result;
        }
    }
}
