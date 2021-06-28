using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Heap
{
    public class MinHeap
    {
        private List<int> heap = new List<int>();

        public void Add(int data)
        {
            heap.Add(data);

            int lastIndex = heap.Count - 1;

            while(lastIndex > 0)
            {
                int parentIndex = (lastIndex - 1) / 2;

                if(heap[lastIndex] < heap[parentIndex])
                {
                    //스왑
                    int temp = heap[parentIndex];
                    heap[parentIndex] = heap[lastIndex];
                    heap[lastIndex] = temp;


                    lastIndex = parentIndex;
                } else
                {
                    break;
                }
            }
        }


        public int Remove()
        {
            if(heap.Count == 0)
            {
                throw new ApplicationException("Heap is empty");
            }

            // 루트 데이터 저장
            int data = heap[0];

            // 마지막 데이터를 루트 데이터로 이동
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            int index = 0;
            int last = heap.Count - 1;

            while(index < last)
            {
                // 왼쪽 자식 노드 계산
                int childIndex = 2 * index + 1;

                // 만약 오른쪽 자식 노드가 더 작다면 오른쪽 자식 노드를 선택
                if(childIndex + 1 <= last && heap[childIndex] > heap[childIndex + 1])
                {
                    childIndex++;
                }
                
                if(childIndex <= last && heap[index] > heap[childIndex])
                {
                    int temp = heap[index];
                    heap[index] = heap[childIndex];
                    heap[childIndex] = temp;

                    index = childIndex;
                } else
                {
                    break;
                }

            }

            return data;
        }

        public void DebugDisplayHeap()
        {
            for (int i = 0; i < heap.Count; i++)
            {
                Console.Write($"{heap[i]} ");
            }
        }

    }
}
