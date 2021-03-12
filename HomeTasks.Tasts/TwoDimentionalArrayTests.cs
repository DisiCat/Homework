using System;
using NUnit.Framework;

namespace HomeTasksLib.Tests
{
    public class TwoDimentionalArrayTests
    {

        [TestCase(1, new int[] { 2, 2 })]
        [TestCase(2, new int[] { 0, 2 })]
        public static void GetIndexOfTheMaximumElementArray_WhenArrayPassed_ShouldReturnIndexMaxElement(int mockNumber, int[] excpected)
        {
            int[,] array = DoubleArrayMock.GetMock(mockNumber);
            int[] actual = TwoDimensionalArray.GetIndexOfTheMaximumElementArray(array);

            Assert.AreEqual(actual, excpected);
        }

        [TestCase(1, new int[] { 0, 0 })]
        [TestCase(2, new int[] { 0, 0 })]
        public static void GetIndexOfTheMinimumElementArray_WhenArrayPassed_ShouldReturnIndexMinElement(int mockNumber, int[] excpected)
        {
            int[,] array = DoubleArrayMock.GetMock(mockNumber);
            int[] actual = TwoDimensionalArray.GetIndexOfTheMinimumElementArray(array);

            Assert.AreEqual(actual, excpected);
        }

        [TestCase(1, 9)]
        [TestCase(2, 2)]
        public static void GetMaximumElementArray_WhenArrayPassed_ShouldReturnMaximumElementArray(int mockNumber, int excpected)
        {
            int[,] array = DoubleArrayMock.GetMock(mockNumber);
            int actual = TwoDimensionalArray.GetMaxElementArray(array);

            Assert.AreEqual(actual, excpected);
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        public static void GetMinimumElementArray_WhenArrayPassed_ShouldReturnMinimumElementArray(int mockNumber, int excpected)
        {
            int[,] array = DoubleArrayMock.GetMock(mockNumber);
            int actual = TwoDimensionalArray.GetMinElementArray(array);

            Assert.AreEqual(actual, excpected);
        }

        [TestCase(1, 3)]
        [TestCase(2, 4)]
        [TestCase(5, 6)]
        public static void FlipAnArrayRelativeToItsMainDiagonal_WhenArrayPassed_ShouldReturnRelativeArrayToMainDiagonal(int mockNumber, int mockExpected)
        {
            int[,] array = DoubleArrayMock.GetMock(mockNumber);
            int[,] expected = DoubleArrayMock.GetMock(mockExpected);
            int[,] actual = TwoDimensionalArray.FlipAnArrayRelativeToItsMainDiagonal(array);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(1, 1)]
        [TestCase(2, 0)]
        [TestCase(5, 1)]
        [TestCase(7, 4)]
        public static void GetNumberElementsArrayThatAreLargerThanAllTheirNeighbors_WhenArrayPassed_ShouldReturnNumber(int mockNumber, int expected)
        {
            int[,] array = DoubleArrayMock.GetMock(mockNumber);
            int actual = TwoDimensionalArray.GetNumberElementsArrayThatAreLargerThanAllTheirNeighbors(array);

            Assert.AreEqual(actual, expected);
        }
    }

    public class DoubleArrayMock
    {
        public static int[,] GetMock(int number)
        {
            int[,] result = new int[0, 0];
            switch (number)
            {
                case 1:
                    result = new int[,] {
                        {1,2,3 },
                        {4,5,6 },
                        {7,8,9 }
                    };
                    break;
                case 2:
                    result = new int[,] {
                        {1,1,2 },
                        {2,2,2 }
                    };
                    break;
                // revers array(case 3) = array(case 1)
                case 3:
                    result = new int[,] {
                        {1,4,7 },
                        {2,5,8 },
                        {3,6,9 }
                    };
                    break;
                // revers array(case 4) = array(case 2)
                case 4:
                    result = new int[,] {
                        {1,2 },
                        {1,2 },
                        {2,2 }
                    };
                    break;
                case 5:
                    result = new int[,] {
                        {1,2 }
                    };
                    break;
                case 6:
                    result = new int[,] {
                        {1 },
                        {2 }
                    };
                    break;
                case 7:
                    result = new int[,] {
                        {10, 4, 11 },
                        {2, 9, 8 },
                        {13, 6, 19 }
                    };
                    break;
            }
            return result;
        }
    }
}
