using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Array
{
    public class DynamicArray2
    {
        private object[] dynamicArray;
        /*
         동적배열에서 흔히 다루는 주제중의 하나는 성장인자인데, 이는 배열이 꽉 찼을 때, 배열을 얼마만큼 늘려야 하는가를 정하는 인자이다.
        성장인자는 각 라이브러리/Framework 마다 다르지만 통상 2배 혹은 1.5배를 많이 사용한다.         
         */
        private const int GROWTH_FACTOR = 2;

        public int Count { get; private set; }
        public int Capecity { get { return dynamicArray.Length; } }

        public DynamicArray2(int capecity = 16)
        {
            dynamicArray = new object[capecity];
        }

        public void Add(object foo)
        {
            if (Count >= Capecity)
            {
                object[] tempObject = new object[Capecity * GROWTH_FACTOR];

                for (int i = 0; i < dynamicArray.Length; i++)
                {
                    tempObject[i] = dynamicArray[i];
                }

                dynamicArray = tempObject;
            }

            dynamicArray[Count++] = foo;
        }

        public object Get(int index)
        {
            if (index > Capecity - 1)
            {
                throw new NullReferenceException();
            } 

            return dynamicArray[index];
        }


    }
}
