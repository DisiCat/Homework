using Xunit;
using HomeTasksLib;
using System;

namespace XUnitHomeTasksLib.Tests
{
    public class ArraysTests
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 4, 54, 3, 2 }, 3)]
        [InlineData(new int[] { 1, 3, 4, 5, 6, 2 }, 4)]
        [InlineData(new int[] { 1, 3, 4, 1, 3, 2 }, 2)]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 1 }, 0)]
        [InlineData(new int[] { 1, 3, 4, 1, 3, 9 }, 5)]
        public void GetMaxElementindex_WhenArrayPassed_ShouldReturnMaxElementindex(int[] array, int expected)
        {
            int actual = Arrays.GetMaxElementindex(array);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { })]
        [InlineData(null)]
        public void GetMaxElementindex_WhenArrayPassed_ShouldReturnArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int actual = Arrays.GetMaxElementindex(array);
            });

        }

        [Theory]
        [InlineData(new int[] { 3, 4, 54, 3, 2 }, 4)]
        [InlineData(new int[] { 1, 3, 4, 5, 6, 2 }, 0)]
        [InlineData(new int[] { 10, 3, 4, 12, 3, 2 }, 5)]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 1 }, 0)]
        [InlineData(new int[] { 1, }, 0)]
        public void GetMinElementindex_WhenArrayPassed_ShouldReturnMinElementindex(int[] array, int expected)
        {
            int actual = Arrays.GetMinElementindex(array);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { })]
        [InlineData(null)]
        public void GetMinElementindex_WhenArrayPassed_ShouldReturnArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int actual = Arrays.GetMinElementindex(array);
            });

        }

        [Theory]
        [InlineData(new int[] { 3, 4, 54, 3, 2 }, 54)]
        [InlineData(new int[] { 1, 3, 4, 5, 6, 2 }, 6)]
        [InlineData(new int[] { 10, 3, 4, 12, 3, 2 }, 12)]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 1 }, 1)]
        [InlineData(new int[] { 10, 1, 2, 3, 4, 5, 10 }, 10)]
        public void GetMax_WhenArrayPassed_ShouldReturnMaxElement(int[] array, int expected)
        {
            int actual = Arrays.GetMax(array);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { })]
        [InlineData(null)]
        public void GetMax_WhenArrayPassed_ShouldReturnArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int actual = Arrays.GetMax(array);
            });

        }

        [Theory]
        [InlineData(new int[] { 3, 4, 54, 3, 2 }, 2)]
        [InlineData(new int[] { 1, 3, 4, 5, 6, 2 }, 1)]
        [InlineData(new int[] { 10, 3, 4, 12, 3, 2 }, 2)]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 1 }, 1)]
        [InlineData(new int[] { 10, 1, 2, 3, 4, 5, 1001, 1, }, 1)]
        public void GetMin_WhenArrayPassed_ShouldReturnMinElement(int[] array, int expected)
        {
            int actual = Arrays.GetMin(array);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { })]
        [InlineData(null)]
        public void GetMin_WhenArrayPassed_ShouldReturnArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int actual = Arrays.GetMin(array);
            });

        }

        [Theory]
        [InlineData(new int[] { 3, 4, 54, 3, 2 }, new int[] { 2, 3, 54, 4, 3 })]
        [InlineData(new int[] { 1, 3, 4, 5, 6, 2 }, new int[] { 2, 6, 5, 4, 3, 1 })]
        [InlineData(new int[] { 10, 3, 4, 12, 3, 2 }, new int[] { 2, 3, 12, 4, 3, 10 })]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1 })]
        [InlineData(new int[] { 10, 1, 2, 3, 4, 5, 10 }, new int[] { 10, 5, 4, 3, 2, 1, 10 })]
        [InlineData(new int[] { 10 }, new int[] { 10 })]
        public void GetReverse_WhenArrayPassed_ShouldReturnReverseArray(int[] array, int[] expected)
        {
            int[] actual = Arrays.GetReverse(array);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { })]
        [InlineData(null)]
        public void GetReverse_WhenArrayPassed_ShouldReturnArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int[] actual = Arrays.GetReverse(array);
            });

        }

        [Theory]
        [InlineData(new int[] { 3, 4, 54, 3, 2 }, new int[] { 54, 4, 3, 3, 2 })]
        [InlineData(new int[] { 1, 3, 4, 5, 6, 2 }, new int[] { 6, 5, 4, 3, 2, 1 })]
        [InlineData(new int[] { 10, 3, 4, 12, 3, 2 }, new int[] { 12, 10, 4, 3, 3, 2 })]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1 })]
        [InlineData(new int[] { 10, 1, 2, 3, 4, 5, 10 }, new int[] { 10, 10, 5, 4, 3, 2, 1 })]
        [InlineData(new int[] { 10 }, new int[] { 10 })]
        public void SortDescendingBubble_WhenArrayPassed_ShouldReturnSortedArray(int[] array, int[] expected)
        {
            int[] actual = Arrays.SortDescendingBubble(array);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { })]
        [InlineData(null)]
        public void SortDescendingBubble_WhenArrayPassed_ShouldReturnArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int[] actual = Arrays.SortDescendingBubble(array);
            });

        }

        [Theory]
        [InlineData(new int[] { 3, 4, 54, 3, 2 }, new int[] { 2, 3, 3, 4, 54 })]
        [InlineData(new int[] { 1, 3, 4, 5, 6, 2 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData(new int[] { 10, 3, 4, 12, 3, 2 }, new int[] { 2, 3, 3, 4, 10, 12 })]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1 })]
        [InlineData(new int[] { 10, 1, 2, 3, 4, 5, 10 }, new int[] { 1, 2, 3, 4, 5, 10, 10 })]
        [InlineData(new int[] { 10 }, new int[] { 10 })]
        public void SortAscendingInsert_WhenArrayPassed_ShouldReturnSortedArray(int[] array, int[] expected)
        {
            int[] actual = Arrays.SortAscendingInsert(array);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(new int[] { })]
        [InlineData(null)]
        public void SortAscendingInsert_WhenArrayPassed_ShouldReturnArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int[] actual = Arrays.SortAscendingInsert(array);
            });

        }

        [Theory]
        [InlineData(new int[] { 3, 4, 54, 3, 2 }, 7)]
        [InlineData(new int[] { 1, 3, 4, 5, 6, 2 }, 10)]
        [InlineData(new int[] { 10, 3, 4, 12, 3, 2 }, 17)]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 1 }, 3)]
        [InlineData(new int[] { 10, 1, 2, 3, 4, 5, 10 }, 9)]
        [InlineData(new int[] { 10 }, 0)]
        public void GetSumElementWithOddIndices_WhenArrayPassed_ShouldReturnSumElementWithOddIndices(int[] array, int expected)
        {
            int actual = Arrays.GetSumElementWithOddIndices(array);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { })]
        [InlineData(null)]
        public void GetSumElementWithOddIndices_WhenArrayPassed_ShouldReturnArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int actual = Arrays.GetSumElementWithOddIndices(array);
            });

        }

        [Theory]
        [InlineData(new int[] { 3, 4, 54, 3, 2 }, new int[] { 3, 2, 54, 3, 4 })]
        [InlineData(new int[] { 1, 3, 4, 5, 6, 2 }, new int[] { 5, 6, 2, 1, 3, 4 })]
        [InlineData(new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 })]
        [InlineData(new int[] { 10, 1 }, new int[] { 1, 10 })]
        [InlineData(new int[] { 10 }, new int[] { 10 })]
        public void SwapFirstAndSecondHalfArray_WhenArrayPassed_ShouldReturnModifiedArray(int[] array, int[] expected)
        {
            int[] actual = Arrays.SwapFirstAndSecondHalfArray(array);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { })]
        [InlineData(null)]
        public void SwapFirstAndSecondHalfArray_WhenArrayPassed_ShouldReturnArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int[] actual = Arrays.SwapFirstAndSecondHalfArray(array);
            });

        }

        [Theory]
        [InlineData(new int[] { 4 }, 0)]
        [InlineData(new int[] { 1, 3, 4, 5, 6, 2 }, 3)]
        [InlineData(new int[] { 1, 1, 1 }, 3)]
        [InlineData(new int[] { 10, 1 }, 1)]
        [InlineData(new int[] { 11 }, 1)]
        public void GetNumberOfOddElements_WhenArrayPassed_ShouldReturnNumberOfOddElements(int[] array, int expected)
        {
            int actual = Arrays.GetNumberOfOddElements(array);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { })]
        [InlineData(null)]
        public void GetNumberOfOddElements_WhenArrayPassed_ShouldReturnArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int actual = Arrays.GetNumberOfOddElements(array);
            });

        }

    }
}
