using System;

namespace HomeTasks
{
    public class Arrays
    {
        public static int GetMaxElementindex(int[] array)
        {
            if (array != null && array.Length > 0)
            {

                int IndexMax = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[IndexMax] < array[i])
                        IndexMax = i;
                }
                return IndexMax;
            }

            throw new ArgumentException("Invalid array entered ");
        }

        public static int GetMinElementindex(int[] array)
        {
            if (array != null && array.Length > 0)
            {

                int IndexMin = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[IndexMin] < array[i])
                        IndexMin = i;
                }
                return IndexMin;
            }

            throw new ArgumentException("Invalid array entered ");
        }

        public static int GetMax(int[] array)
        {
            if (array != null && array.Length > 0)
            {
                return array[GetMaxElementindex(array)];
            }

            throw new ArgumentException("Invalid array entered ");

        }

        public static int GetMin(int[] array)
        {
            if (array != null && array.Length > 0)
            {
                return array[GetMinElementindex(array)];
            }

            throw new ArgumentException("Invalid array entered ");
        }

        public static int[] GetReverse(int[] array)
        {
            if (array != null && array.Length > 0)
            {

                int temp;
                int lengthArray = array.Length - 1;
                for (int i = 0; i < array.Length / 2; i++)
                {
                    temp = array[i];
                    array[i] = array[lengthArray - i];
                    array[lengthArray - i] = temp;
                }
                return array;
            }

            throw new ArgumentException("Invalid array entered ");

        }

        public static int[] SortDescendingBubble(int[] array)
        {
            if (array != null && array.Length > 0)
            {

                int temp;
                for (int i = 0; i < array.Length - 1; i++)
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] < array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                return array;
            }

            throw new ArgumentException("Invalid array entered ");
        }

        public static int[] SortAscendingInsert(int[] array)
        {
            if (array != null && array.Length > 0)
            {

                int j;
                int temp;
                for (int i = 1; i < array.Length; i++)
                {

                    j = i;
                    temp = array[i];

                    while (j > 0 && temp < array[j - 1])
                    {
                        array[j] = array[j - 1];
                        j--;
                    }

                    array[j] = temp;

                }
                return array;
            }

            throw new ArgumentException("Invalid array entered ");
        }

        public static int GetSumElementWithOddIndices(int[] array)
        {
            if (array != null && array.Length > 0)
            {

                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += array[i];
                    }
                }

                return sum;
            }

            throw new ArgumentException("Invalid array entered ");
        }

        public static int[] SwapFirstAndSecondHalfArray(int[] array)
        {
            if (array != null && array.Length > 0)
            {

                int temp;
                int swapElements = array.Length / 2 + array.Length % 2;

                for (int i = 0; i < array.Length / 2; i++)
                {
                    temp = array[i];
                    array[i] = array[i + swapElements];
                    array[swapElements + i] = temp;
                }

                return array;
            }

            throw new ArgumentException("Invalid array entered ");
        }
        public static int GetNumberOfOddElements(int[] array)
        {

            if (array != null && array.Length > 0)
            {

                int counter = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        counter++;
                    }
                }
                return counter;
            }

            throw new ArgumentException("Invalid array entered ");
        }


    }
}
