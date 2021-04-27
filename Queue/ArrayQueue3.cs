using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Queue
{
    public class ArrayQueue3
    {
        private object[] queue;
        private int front;
        private int rear;

        private int count;

        public ArrayQueue3(int queueSize = 16)
        {
            queue = new object[queueSize];
            front = 0;
            rear = 0;
            count = 0;
        }

        public void Enqueue(object data)
        {
            if(count == queue.Length)
            {
                Console.WriteLine("Queue is full");
                return;
            }

            queue[rear] = data;
            rear = (rear + 1) % queue.Length;
            count++;
        }

        public object Dequeue()
        {
            if(count <= 0)
            {
                Console.WriteLine("Queue is empty");
                return null;
            }

            var result = queue[front];
            queue[front] = null;
            front = (front + 1) % queue.Length;
            count--;

            return null;
        }
    }
}
