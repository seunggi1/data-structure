using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedList
{
    public class LinkedListOfDotNet
    {
        LinkedList<int> linkedList = new LinkedList<int>();

        public LinkedListOfDotNet()
        {
            linkedList.AddLast(new LinkedListNode<int>(55));

            linkedList.AddFirst(67);
            linkedList.AddFirst(69);
            linkedList.AddFirst(687);

            linkedList.RemoveFirst();
            linkedList.Remove(687);
            linkedList.RemoveLast();
        }

    }
}
