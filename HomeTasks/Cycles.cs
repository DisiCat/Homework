using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTasksLib
{
    public class Cycles
    {
        public static int Pow(int a, int b)
        {
            if (!(b <= 0 || a < 0))
            {
                int temp = a;
                for (int i = 1; i < b; i++)
                {
                    a *= temp;
                }
                return a;
            }

            throw new ArgumentException("Enter correct values");
        }

        public static int[] GetNumbersDivisibleByA(int a)
        {
            if (!(a <= 0 || a > 1000))
            {
                int[] array = new int[1000 / a];
                int j = 0;
                for (int i = a; i <= 1000; i += a)
                {
                    array[j] = i;
                    ++j;
                }
                return array;
            }

            throw new ArgumentException("invalid A");

        }

        public static int GetNumberOfPositiveIntegersWhoseSquareLessA(int a)
        {
            int i = 1;
            int counter = 0;
            while(i*i < a)
            {
                ++i;
                ++counter;
            }
            return counter;
        }


        public static int GetLargestDivisorByA(int a)
        {
            if(!(a <= 0))
            {
                int divisorNumber = 0;
                for (int i = 1; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        divisorNumber = i;
                    }
                }
                return divisorNumber;
            }

            throw new ArgumentException("incorrect value entered");
        }

        public static int GetSumOfAllNumbersInRangeThatAreEvenlyDivisibleBy7(int a,int b)
        {
            if (!(a < 0 || b < 0))
            {

            int temp;
            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }

            return sum;
            }

            throw new ArgumentException("incorrect value entered");
        }

        public static int GetNthNumberOfFibonacciSeries(int n)
        {
            if (n > 0)
            {
                int fib1 = 1;
                int fib2 = 1;
                int fibSum;
                int i = 0;

                while (i < n - 2)
                {
                    fibSum = fib1 + fib2;
                    fib1 = fib2;
                    fib2 = fibSum;
                    i++;
                }

                return fib2;
            }

            throw new ArgumentException("incorrect value entered");
        }

        public static int GetGreatestCommonDivisorUsingEuclidsAlgo(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }

            return a;
        }

        public static int GetNumberUsingTheHalfDivisionMethod(int number)
        {
            if (number != 1)
            {
                int left = 1;
                int right = number;
                int middle = 0;
                int midllePow3 = 0;
                while (number != midllePow3)
                {
                    middle = left + (right - left) / 2;
                    midllePow3 = middle * middle * middle;

                    if (number < (midllePow3))
                    {
                        right = middle - 1;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }
              
                return middle;

            }
            else
            {
                return number;
            }

        }

        public static int GetNumberOfOddDigitsOfNumber(int number)
        {
            int counter = 0;
            for (int i = number; i > 0; i /= 10)
            {
                if ((i % 10) % 2 == 1)
                {
                    counter++;
                }
            }
            return counter;
        }


        public static int GetReversNumber (int number)
        {
            int reversNum = 0;
            while (number > 0)
            {
                reversNum = (reversNum * 10) + number % 10;
                number /= 10;
            }
            return reversNum;
        }

        public static int[] GetNumbersSumOfEvenDigitsIsGreaterSumOdd(int number)
        {
            if(!(number < 1))
            {
                int counter = 0;
                for (int i = 1; i <= number; i++)
                {
                    int sumEvenNum = 0;
                    int sumOddNum = 0;

                    for (int j = i; j > 0; j /= 10)
                    {
                        int numeral = j % 10;

                        if (numeral % 2 == 0)
                        {
                            sumEvenNum += numeral;
                        }
                        else
                        {
                            sumOddNum += numeral;
                        }

                    }

                    if (sumEvenNum > sumOddNum)
                    {
                        ++counter;
                    }
                }

                int[] array = new int[counter];
                int k = 0;
                for (int i = 1; i <= number; i++)
                {
                    int sumEvenNum = 0;
                    int sumOddNum = 0;

                    for (int j = i; j > 0; j /= 10)
                    {
                        int numeral = j % 10;

                        if (numeral % 2 == 0)
                        {
                            sumEvenNum += numeral;
                        }
                        else
                        {
                            sumOddNum += numeral;
                        }
                    }

                    if (sumEvenNum > sumOddNum)
                    {
                        array[k] = i;
                        ++k;
                    }
                }
                return array;
            }

            throw new ArgumentException("Entered a non-integer positive number");
            
        }

        public static bool GetTrueOrFalseIfNumbersHaveSameDigits(int firstNum, int secondNum)
        {
            int numeral;
            bool numbersEqual = false;
           
            for (int i = firstNum; i > 0 && numbersEqual == false; i /= 10)
            {
                numeral = firstNum % 10;

                for (int j = secondNum; j > 0; j /= 10)
                {

                    if (numeral == j % 10)
                    {
                        numbersEqual = true;
                        break;
                    }
                }
            }
            return numbersEqual;
        }
    }
}
