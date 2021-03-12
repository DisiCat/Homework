using System;
using System.Collections.Generic;
using HomeTasksLib;

namespace Homework
{
    class Program
    {

        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            Random rand = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(10, 100);
                    Console.Write($"[{array[i, j]}]");
                }
                Console.WriteLine();
            }

            //int[] arrayIndex = TwoDimensionalArray.GetIndexOfTheMinimumElementArray(array);
            
            //for (int i = 0; i < arrayIndex.Length; i++)
            //{
            //    Console.Write(arrayIndex[i]);
            //}

            Console.Write(TwoDimensionalArray.GetMinElementArray(array));
            Console.Write(TwoDimensionalArray.GetMaxElementArray(array));

        }
    }
}
