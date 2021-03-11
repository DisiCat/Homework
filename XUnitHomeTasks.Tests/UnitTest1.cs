using System;
using Xunit;
using HomeTasks;

namespace XUnitHomeTasks.Tests
{
    public class ArraysTests
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 4, 54, 3, 2 },3) ]
        [InlineData(new int[] { 1, 3, 4, 5, 6, 2 }, 4)]
        [InlineData(new int[] { 1, 3, 4, 1, 3, 2 }, 2)]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 1 }, 0)]
        [InlineData(new int[] { 1, 3, 4, 1, 3, 9 }, 5)]
        public void GetMaxElementindex_WhenArrayPassed_ShouldReturnMaxElementindex(int[] array, int expected)
        {
            int actual = Arrays.GetMaxElementindex(array);
            Assert.Equal(expected, actual);
        }
    }
}
