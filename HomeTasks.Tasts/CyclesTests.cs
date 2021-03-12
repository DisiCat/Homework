using NUnit.Framework;
using System;
namespace HomeTasksLib.Tests
{
    public class CyclesTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(0, 2, 0)]
        [TestCase(10, 3, 1000)]
        [TestCase(2, 1, 2)]
        public void Pow_WhenABPassed_ShouldReturnAPowerB(int a, int b, int expected)
        {
            int actual = Cycles.Pow(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 0)]
        [TestCase(0, -1)]
        [TestCase(-2, 1)]
        public void Pow_WhenABPassed_ShouldReturnArgumentException(int a, int b)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int actual = Cycles.Pow(a, b);
            });
        }

        [TestCase(1000, new int[] { 1000 })]
        [TestCase(500, new int[] { 500, 1000 })]
        [TestCase(700, new int[] { 700 })]
        public void NumbersDivisibleByA_WhenAPassed_ShouldReturnNumbersDivisibleByA(int a, int[] expectedArr)
        {
            int[] actualArr = Cycles.GetNumbersDivisibleByA(a);

            Assert.AreEqual(expectedArr, actualArr);
        }

        [TestCase(0)]
        [TestCase(1001)]
        [TestCase(-1)]
        public void NumbersDivisibleByA_WhenAPassed_ShouldReturnArgumentException(int a)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int[] actualArr = Cycles.GetNumbersDivisibleByA(a);
            });
        }

        [TestCase(10, 3)]
        [TestCase(1, 0)]
        [TestCase(17, 4)]
        public void GetNumberOfPositiveIntegersWhoseSquareLessA_WhenAPassed_ShouldReturnNumberOfPositiveIntegersWhoseSquareLessA(int a, int expected)
        {
            int actual = Cycles.GetNumberOfPositiveIntegersWhoseSquareLessA(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(9, 3)]
        [TestCase(4, 2)]
        [TestCase(5, 1)]
        [TestCase(6, 3)]
        [TestCase(12, 6)]
        public void GetLargestDivisorByA_WhenAPassed_ShouldReturnLargestDivisorByA(int a, int expected)
        {
            int actual = Cycles.GetLargestDivisorByA(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void GetLargestDivisorByA_WhenAPassed_ShouldReturnArgumentException(int a)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int actual = Cycles.GetLargestDivisorByA(a);
            });
        }

        [TestCase(1, 7, 7)]
        [TestCase(7, 1, 7)]
        [TestCase(1, 3, 0)]
        [TestCase(7, 14, 21)]
        [TestCase(12, 6, 7)]
        public void GetSumOfAllNumbersInRangeThatAreEvenlyDivisibleBy7_WhenARangeBPassed_ShouldReturnSumNumbersDivisibleBy7(int a, int b, int expected)
        {
            int actual = Cycles.GetSumOfAllNumbersInRangeThatAreEvenlyDivisibleBy7(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-1, 3)]
        [TestCase(3, -1)]
        [TestCase(-12, -6)]
        public void GetSumOfAllNumbersInRangeThatAreEvenlyDivisibleBy7_WhenARangeBPassed_ShouldReturnArgumentException(int a, int b)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int actual = Cycles.GetSumOfAllNumbersInRangeThatAreEvenlyDivisibleBy7(a, b);
            });
        }

        [TestCase(5, 5)]
        [TestCase(1, 1)]
        [TestCase(6, 8)]
        public void GetNthNumberOfFibonacciSeries_WhenNPassed_ShouldReturnNthNumberOfFibonacciSeries(int number, int expected)
        {
            int actual = Cycles.GetNthNumberOfFibonacciSeries(number);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void GetNthNumberOfFibonacciSeries_WhenNPassed_ShouldReturnArgumentException(int number)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int actual = Cycles.GetNthNumberOfFibonacciSeries(number);
            });

        }

        [TestCase(10, 5, 5)]
        [TestCase(0, 0, 0)]
        [TestCase(22, 11, 11)]
        public void GetGreatestCommonDivisorUsingEuclidsAlgo_WhenABPassed_ShouldReturnGreatestCommonDivisorUsingEuclidsAlgo(int a, int b, int expected)
        {
            int actual = Cycles.GetGreatestCommonDivisorUsingEuclidsAlgo(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(8, 2)]
        [TestCase(27, 3)]
        public void GetNumberUsingTheHalfDivisionMethod_WhenNumberPassed_ShouldReturnNumberUsingTheHalfDivisionMethod(int number, int expected)
        {
            int actual = Cycles.GetNumberUsingTheHalfDivisionMethod(number);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(11, 2)]
        [TestCase(1121, 3)]
        [TestCase(222, 0)]
        [TestCase(0, 0)]
        public void GetNumberOfOddDigitsOfNumber_WhenNumberPassed_ShouldReturnNumberOfOddDigitsOfNumber(int number, int expected)
        {
            int actual = Cycles.GetNumberOfOddDigitsOfNumber(number);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(123, 321)]
        [TestCase(11, 11)]
        [TestCase(22234, 43222)]
        [TestCase(223, 322)]
        public void GetReversNumber_WhenNumberPassed_ShouldReturnReversNumber(int number, int expected)
        {
            int actual = Cycles.GetReversNumber(number);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, new int[] { 2, 4, 6, 8 })]
        [TestCase(2, new int[] { 2 })]
        [TestCase(16, new int[] { 2, 4, 6, 8, 12, 14, 16 })]
        [TestCase(1, new int[] { })]

        public void GetNumbersSumOfEvenDigitsIsGreaterSumOdd_WhenNumberPassed_ShouldReturnNumbersSumOfEvenDigitsIsGreaterSumOdd(int number, int[] expectedArr)
        {
            int[] actualArr = Cycles.GetNumbersSumOfEvenDigitsIsGreaterSumOdd(number);

            Assert.AreEqual(expectedArr, actualArr);
        }

        [TestCase(0)]
        public void GetNumbersSumOfEvenDigitsIsGreaterSumOdd_WhenNumberPassed_ShouldReturnArgumentException(int number)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int[] actualArr = Cycles.GetNumbersSumOfEvenDigitsIsGreaterSumOdd(number);
            });
        }

        [TestCase(44, 40, true)]
        [TestCase(222, 111, false)]
        [TestCase(1, 101, true)]
        public void GetTrueOrFalseIfNumbersHaveSameDigits_WhenNumberPassed_ShouldReturn1Or0(int firstNum, int secondNum, bool expected)
        {
            bool actual = Cycles.GetTrueOrFalseIfNumbersHaveSameDigits(firstNum, secondNum);

            Assert.AreEqual(expected, actual);
        }
    }

}
