using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Heap
{
    public class MaxHeap
    {
        private List<int> heap = new List<int>();

  
        public void Add(int data)
        {
            // 1. 새 요소를 배열 마지막에 추가한다. 추가된 요소가 현재 노드가 된다.
            heap.Add(data);

            int index = heap.Count - 1;
            // 2. 현재 노드가 루트에 도달할 때까지 루프를 돈다.
            while(index > 0)
            {
                int parent = (index - 1) / 2;


                // - 현재 노드가 부모 노드보다 크면 둘을 서로 교체한다. 부모노드를 현재노드로 놓고 계속 루프를 돈다. 즉 부모, 조부모등으로 계속 직계 조상들을 비교하게 된다.
                // - 현재 노드가 부모 노드보다 작거나 같으면 루프를 빠져나온다.

                if (heap[index] > heap[parent])
                {
                    int temp = heap[index];
                    heap[index] = heap[parent];
                    heap[parent] = temp;

                    index = parent;
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
                Console.WriteLine("Heap is empty");
                return -1111;
            }

            //루트 최대값 저장
            int data = heap[0];

            // 마지막 요소를 처음으로 이동
            heap[0] = heap[heap.Count - 1];

            // 마지막 요소 제거
            heap.RemoveAt(heap.Count - 1);

            // Reheapification downward
            int i = 0;
            int last = heap.Count - 1;

            while(i < last)
            {
                // 왼쪽 자식 노드
                int child = 2 * i + 1;

                // 오른쪽 자식노드가 더 크면 오른쪽 선택
                if(child < last && heap[child] < heap[child + 1])
                {
                    child++;
                }

                //인덱스가 초과되거나 자식노드보다 크거나 같으면 중지
                if(child > last || heap[i] >= heap[child])
                {
                    break;
                }

                int temp = heap[i];
                heap[i] = heap[child];
                heap[child] = temp;

                i = child;
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
