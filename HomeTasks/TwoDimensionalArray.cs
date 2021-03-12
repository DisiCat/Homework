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
                int[] arr = GetIndexOfTheMinimumElementArray(array);
                int min = array[arr[0], arr[1]];

                return min;
        }

        public static int GetMaxElementArray(int[,] array)
        {
                int[] arr = GetIndexOfTheMaximumElementArray(array);
                int max = array[arr[0], arr[1]];

                return max;
        }

        public static int[,] FlipAnArrayRelativeToItsMainDiagonal(int[,] array)
        {
            if (!(array == null || array.Length < 0))
            {
                int[,] RelativeArray = new int[array.GetLength(0), array.GetLength(1)];
                if (array.GetLength(0) == array.GetLength(1))
                {

                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = i; j < array.GetLength(1); j++)
                        {
                            if (i != j)
                            {
                                RelativeArray[j, i] = array[i, j];

                            }
                        }
                    }

                }
                else
                {
                    RelativeArray = new int[array.GetLength(1), array.GetLength(0)];
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            RelativeArray[j, i] = array[i, j];
                        }
                    }


                }
                return RelativeArray;
            }

            throw new ArgumentException("invalid array");

        }

        public static int GetNumberElementsArrayThatAreLargerThanAllTheirNeighbors(int[,] array)
        {
            if (!(array == null || array.Length < 0))
            {

                int counter = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {

                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        var conditionsPassed = true;
                        for (int k = -1; k <= 1 && conditionsPassed; k++)
                        {
                            int NewIndexI = i - k;
                            for (int l = -1; l <= 1; l++)
                            {
                                int NewIndexJ = j - l;
                                if ((NewIndexI != i || NewIndexJ != j)
                                   && NewIndexI >= 0 && NewIndexI < array.GetLength(0)
                                   && NewIndexJ >= 0 && NewIndexJ < array.GetLength(1)
                                   && array[i, j] <= array[NewIndexI, NewIndexJ])
                                {
                                    conditionsPassed = false;
                                    break;
                                }
                            }
                        }

                        if (conditionsPassed)
                        {
                            ++counter;
                        }
                    }
                }
                return counter;
            }
            throw new ArgumentException("invalid array");

        }
    }

}

