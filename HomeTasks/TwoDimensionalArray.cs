using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTasksLib
{
    public class TwoDimensionalArray
    {
        public static int[] GetIndexOfTheMaximumElementArray(int[,] array)
        {
            if (!(array == null || array.Length < 0))
            {
                int maxIndexI = 0;
                int maxindexJ = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {

                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[maxIndexI, maxindexJ] < array[i, j])
                        {
                            maxIndexI = i;
                            maxindexJ = j;
                        }
                    }
                }

                return new int[] { maxIndexI, maxindexJ };
            }

            throw new ArgumentException("invalid array");
        }
        public static int[] GetIndexOfTheMinimumElementArray(int[,] array)
        {
            if (array == null || array.Length > 0)
            {
                int minIndexI = 0;
                int minindexJ = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {

                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[minIndexI, minindexJ] > array[i, j])
                        {
                            minIndexI = i;
                            minindexJ = j;
                        }
                    }
                }

                return new int[] { minIndexI, minindexJ };
            }

            throw new ArgumentException("invalid array");
        }

        public static int GetMinElementArray(int[,] array)
        {
            if (!(array == null || array.Length < 0))
            {
                int[] arr = GetIndexOfTheMinimumElementArray(array);
                int min = array[arr[0], arr[1]];

                return min;
            }

            throw new ArgumentException("invalid array");
        }

        public static int GetMaxElementArray(int[,] array)
        {
            if (!(array == null || array.Length < 0))
            {
                int[] arr = GetIndexOfTheMaximumElementArray(array);
                int max = array[arr[0], arr[1]];

                return max;
            }

            throw new ArgumentException("invalid array");
        }
    }


}

