using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinaryTree
{
    public class BinaryTree_Array
    {
        private object[] arr;
        public object Root { get { return arr[0]; } set { arr[0] = value;  } }


        public BinaryTree_Array(int capecity = 16)
        {
            arr = new object[capecity];
        }

        public void SetLeft(int parentIndex, object data)
        {
            if( arr[parentIndex] == null)
            {
                return;
            }

            int leftIndex = 2 * parentIndex + 1;

            if(leftIndex >= arr.Length)
            {
                return;
            }

            arr[leftIndex] = data;
        }

        public void SetRight(int parentIndex, object data)
        {
            if (arr[parentIndex] == null)
            {
                return;
            }

            int rightIndex = 2 * parentIndex + 2;

            if(rightIndex >= arr.Length)
            {
                return;
            }

            arr[rightIndex] = data;
        }

        public object GetLeft(int parentIndex)
        {
            int leftIndex = 2 * parentIndex + 1;

            return arr[leftIndex];
        }

        public object GetRight(int parentIndex)
        {
            int rightIndex = 2 * parentIndex + 2;

            return arr[rightIndex];
        }

        public object GetParent(int childIndex)
        {
            if(childIndex == 0)
            {
                return null;
            }

            int parentIndex = (childIndex - 1) / 2;

            return arr[parentIndex];
        }

        public void PrintTree()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i] ?? "-"}");
            }

            Console.WriteLine();
        }
    }
}
