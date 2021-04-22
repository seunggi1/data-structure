using System;

namespace DataStructure.Array
{
    public class JaggedArray
    {
        public JaggedArray()
        {
            Console.WriteLine("This is jagged array");

            int[][] jaggedArray = new int[3][]
            {   
                new int[]{1, 3, 56, 6767, 77},
                new int[]{434546, 546, 12, 46, 7},
                new int[]{6}
            };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length  ; j++)
                {
                    Console.Write($"{jaggedArray[i][j]} ");
                }                
                 System.Console.WriteLine();
            }           
        }
    }
}


