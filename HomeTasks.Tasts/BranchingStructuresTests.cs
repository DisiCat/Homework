using NUnit.Framework;
using System;
namespace HomeTasksLib.Tests
{
    public class BranchingStructuresTests
    {
        [TestCase(1, 2, -1)]
        [TestCase(2, 2, 4)]
        [TestCase(8, 2, 10)]
        [TestCase(3, 3, 9)]
        [TestCase(0, -1, -1)]
        public void CompareAB_WhenABPassed_ShouldReturnAPlusBOrAMultiBOrAMinusB(int a, int b, int expected)
        {
            int actual = BranchingStructures.CompareTwoValuesAndReturnAPlusBOrAMultiBOrAMinusB(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 1)]
        [TestCase(2, -1, 4)]
        [TestCase(-3, 2, 2)]
        [TestCase(-3, -2, 3)]
        public void Quarter_WhenXYPassed_ShouldReturnQuarter(int x, int y, int expected)
        {
            int actual = BranchingStructures.GetQuarter(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 0)]
        [TestCase(0, -1)]
        [TestCase(0, 0)]
        public void Quarter_WhenXYPassed_ShouldReturnArgumentException(int x, int y)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int actual = BranchingStructures.GetQuarter(x, y);
            });
        }

        [TestCase(1, 2, 1, 1, 1, 2)]
        [TestCase(2, -1, 4, -1, 2, 4)]
        [TestCase(-3, 2, 2, -3, 2, 2)]
        [TestCase(-3, -2, 3, -3, -2, 3)]
        public void AscendingOrder_WhenABCPassed_ShouldResultABCAscendingOrder(int a, int b, int c, int expectedA, int expectedB, int expectedC)
        {
            BranchingStructures.GetAscendingOrder(ref a, ref b, ref c);
            int actualA = a;
            int actualB = b;
            int actualC = c;

            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);
            Assert.AreEqual(expectedC, actualC);
        }

        [TestCase(1, 2, 3, new double[] { })]
        [TestCase(3, 5, 1, new double[] { -1.434, -0.232 })]
        [TestCase(-3, 2, 2, new double[] { 1.215, -0.549 })]
        [TestCase(1, 2, 1, new double[] { -1 })]
        public void QuadraticEquation_WhenABCPassed_ShouldResultQuadraticEquation(int a, int b, int c, double[] expectedArr)
        {
            double[] actualArr = BranchingStructures.GetSolutionQuadraticEquation(a, b, c);

            Assert.AreEqual(expectedArr, actualArr);
        }

        [TestCase(0, 2, 3)]
        public void QuadraticEquation_WhenABCPassed_ShouldResultDivideByZeroException(int a, int b, int c)
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                double[] actualArr = BranchingStructures.GetSolutionQuadraticEquation(a, b, c);
            });

        }

        [TestCase(10, "десять")]
        [TestCase(21, "Двадцать один")]
        [TestCase(73, "Семьдесят три")]
        public void UppercaseNumber_WhenNumberPassed_ShouldResultUppercaseNumber(int a, string expectedUppercaseNumber)
        {
            string actualUppercaseNumber = BranchingStructures.GetUppercaseNumber(a);

            Assert.AreEqual(expectedUppercaseNumber, actualUppercaseNumber);
        }

        [TestCase(0)]
        [TestCase(100)]
        [TestCase(123)]
        public void UppercaseNumber_WhenNumberPassed_ShouldReturnArgumentException(int a)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                string actualUppercaseNumber = BranchingStructures.GetUppercaseNumber(a);
            });
        }

    }
}
