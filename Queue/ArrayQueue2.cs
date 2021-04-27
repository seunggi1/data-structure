using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Queue
{
    public class ArrayQueue2
    {
        private object[] queue;        
        private int front;
        private int rear;

        public ArrayQueue2(int queueSize = 16)
        {
            queue = new object[queueSize];
            front = 0;
            rear = 0;
        }

        public void Enqueue(object data)
        {
            if((rear + 1) % queue.Length == front)
            {
                Console.WriteLine("Queue is full");
                return;
            }
           
            if(front == 0)
            {
                front++;
                rear++;
            }

            queue[rear] = data;
            rear = (rear + 1) % queue.Length;
        }

        public object Dequeue()
        {
            if(front == rear)
            {
                Console.WriteLine("Queue is Empty");
                return null;
            }
            
            var result = queue[front];
            queue[front] = null;
            front = (front + 1) % queue.Length;

            return result;
        }
    }
}
