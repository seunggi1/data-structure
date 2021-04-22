using System;

namespace DataStructure.Array
{
    public class BaseArray
    {
        public BaseArray()
        {
            SingleDimensionalArray();
            MultiDimensionalArray();
        }

        public void SingleDimensionalArray()
        {
            Console.WriteLine("This is Single demension array");

            int[] intArray = new int[3] { 3, 4, 7 };

            for (int i = 0; i < intArray.Length; i++)
            {
                System.Console.Write($"{intArray[i]} ");
            }

            System.Console.WriteLine();
        }

        public void MultiDimensionalArray()
        {
            Console.WriteLine("This is Multi demension array");

            int[,] intArray = new int[3, 4]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };

            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    Console.Write($"{intArray[i, j]} ");
                }
            }

            System.Console.WriteLine();
        }
    }
}