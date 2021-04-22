using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Array
{
    public class CircularArray
    {
        private object[] circularArray;
        private int Pointer { get; set; }

        public CircularArray(int length)
        {
            circularArray = new object[length];
        }

        public void Insert(object foo)
        {
            if (Pointer >= circularArray.Length)
            {
                Pointer = Pointer % circularArray.Length;
            }

            circularArray[Pointer++] = foo;
        }

        public object Get(int index)
        {
            if(index >= circularArray.Length)
            {
                return circularArray[index % circularArray.Length];
            }

            return circularArray[index];
        }
    }
}
