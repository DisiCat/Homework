using System;
using System.Collections.Generic;
using HomeTasks;

namespace Homework
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = Cycles.GetNumbersSumOfEvenDigitsIsGreaterSumOdd(25);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }

        }
    }
}
