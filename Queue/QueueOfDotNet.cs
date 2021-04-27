using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DataStructure.Queue
{
    public class QueueOfDotNet
    {
        public Queue<object> queue;

        public QueueOfDotNet(int queueSize = 16)
        {
            queue = new Queue<object>(queueSize);
        }

        public void Enqueue(object data)
        {
            queue.Enqueue(data);
        }

        public object Dequeue()
        {
            return queue.Dequeue();
        }

    }
}
