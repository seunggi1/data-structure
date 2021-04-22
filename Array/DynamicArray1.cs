using System;

namespace DataStructure.Array
{
    public class DynamicArray1
    {

        private object[] dynamicArray = new object[0];

        public DynamicArray1()
        {
            System.Console.WriteLine("This is Dynamic array");
        }


        /*
            아래와 같은 동적 배열은 필요할때 마다 배열의 하나씩 증가시키는 방식으로 꼭 필요한 공간만을 사용한다는 장점이있지만,
            매번 새로운 배열 공간을 생성하고 여기에 기존 배열 요소들을 넣어야한다는 단점이있다.

            이러한 방식은 배열에 하나의 요소를 추가할 때마다 전체 기존 배열을 복사해야 하기때문에, 배열의 크기가 n 일때 O(n) 시간이 소요된다.
            예를 들어 배열의 크기가 1일때 새요소를 추가하면 기존 배열 오소를 1개 복사해야하고, 배열 크기가 2일 때는 2개를, 3개일땐 3개를..
            이런한 방식으로 임의의 배열 크기가 n 일때, n개를 복사하는 동작을 수행하여야한다.
        */
        public void Add(object foo)
        {
            object[] tempArray = new object[dynamicArray.Length + 1];

            for (int i = 0; i < dynamicArray.Length; i++)
            {
                tempArray[i] = dynamicArray[i];
            }

            tempArray[dynamicArray.Length] = foo;

            dynamicArray = tempArray;
        }

        public object Get(int index)
        {
            if (index >= dynamicArray.Length)
            {
                throw new IndexOutOfRangeException();
            }

            return dynamicArray[index];
        }
    }
}