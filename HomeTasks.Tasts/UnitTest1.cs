using NUnit.Framework;
using System;

namespace HomeTasksLib.Tests
{
    public class VariablesTests
    {

        [TestCase(5, 3, -17)]
        [TestCase(0, 4, 4)]
        [TestCase(10, 8, -57)]
        [TestCase(10, -8, -6)]
        public void ResultEquation_WhenABPassed_ShouldReturnResultEquation(int a, int b, int expected)
        {
            int actual = Variables.GetResultEquation(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(-1, -1)]
        [TestCase(1, 1)]
        public void ResultEquation_WhenABPassed_ShouldReturnThrowException(int a, int b)
        {

            Assert.Throws<ArgumentException>(() =>
            {
                int actual = Variables.GetResultEquation(a, b);


            });
        }


        [TestCase(5, 3, 3, 5)]
        [TestCase(0, 0, 0, 0)]
        [TestCase(10, 8, 8, 10)]
        [TestCase(10, -8, -8, 10)]
        public void Swap_WhenABPassed_ShouldReturnASwapB(int a, int b, int expectedA, int expectedB)
        {
            Variables.SwapValueOfVariables(ref a, ref b);
            int actualA = a;
            int actualB = b;

            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);
        }

        [TestCase(4, 2, 2, 0)]
        [TestCase(2, 4, 0.5, 2)]
        [TestCase(10, 8, 1.25, 2)]
        [TestCase(12, -3, -4, 0)]
        public void DivisionAndRemainder_WhenABPassed_ShouldReturnADivisionBAndARemainderB(int a, int b, double expectedDivision, int expectedRemainder)
        {
            double actualDivision = 0;
            int actualRemainder = 0;
            Variables.GetDivisionAndRemainder(a, b, ref actualDivision, ref actualRemainder);

            Assert.AreEqual(expectedDivision, actualDivision);
            Assert.AreEqual(expectedRemainder, actualRemainder);
        }

        [TestCase(1, 2, 3, 1)]
        [TestCase(2, 2, 2, 0)]
        [TestCase(1, 8, 10, 2)]
        [TestCase(4, 3, 12, 2.25)]
        public void LinearEquation_WhenABCPassed_ShouldReturnResultLinearEquation(int a, int b, int c, double expected)
        {
            double actual = Variables.GetSolutionLinearEquation(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 2, 1, 1, new double[] { 0.5, 0.5 })]
        [TestCase(4, 1, 3, 4, new double[] { -3, 13 })]
        [TestCase(1, 8, 10, 2, new double[] { -0.667, 8.667 })]
        [TestCase(4, 3, 12, 2.25, new double[] { -0.094, 3.375 })]
        public void EquationOfStraightLine_WhenX1Y1X2Y2Passed_ShouldReturnResultEquationOfStraightLine(double x1, double y1, double x2, double y2, double[] expectedArr)
        {
            double[] actualArr = Variables.GetEquationOfStraightLine(x1, y1, x2, y2);

            Assert.AreEqual(expectedArr, actualArr);
        }
    }

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

        [TestCase(10, "десять")]
        [TestCase(21, "Двадцать один")]
        [TestCase(73, "Семьдесят три")]
        public void UppercaseNumber_WhenNumberPassed_ShouldResultUppercaseNumber(int a, string expectedUppercaseNumber)
        {
            string actualUppercaseNumber = BranchingStructures.GetUppercaseNumber(a);

            Assert.AreEqual(expectedUppercaseNumber, actualUppercaseNumber);
        }

    }

    public class CyclesTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(0, 2, 0)]
        [TestCase(3, 2, 9)]
        [TestCase(10, 3, 1000)]
        [TestCase(2, 1, 2)]
        public void Pow_WhenABPassed_ShouldReturnAPowerB(int a, int b, int expected)
        {
            int actual = Cycles.Pow(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1000, new int[] { 1000 })]
        [TestCase(500, new int[] { 500, 1000 })]
        [TestCase(700, new int[] { 700 })]
        public void NumbersDivisibleByA_WhenAPassed_ShouldReturnNumbersDivisibleByA(int a, int[] expectedArr)
        {
            int[] actualArr = Cycles.GetNumbersDivisibleByA(a);

            Assert.AreEqual(expectedArr, actualArr);
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

        [TestCase(1, 7, 7)]
        [TestCase(7, 1, 7)]
        [TestCase(1, 3, 0)]
        [TestCase(7, 14, 21)]
        [TestCase(12, 6, 7)]
        public void GetSumOfAllNumbersInRangeThatAreEvenlyDivisibleBy7_WhenARangeBPassed_ShouldReturnGetSumOfAllNumbersInRangeThatAreEvenlyDivisibleBy7(int a, int b, int expected)
        {
            int actual = Cycles.GetSumOfAllNumbersInRangeThatAreEvenlyDivisibleBy7(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 5 )]
        [TestCase(1, 1)]
        [TestCase(6, 8)]
        public void GetNthNumberOfFibonacciSeries_WhenNPassed_ShouldReturnNthNumberOfFibonacciSeries(int number, int expected)
        {
            int actual = Cycles.GetNthNumberOfFibonacciSeries(number);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 5,5)]
        [TestCase(0, 0,0)]
        [TestCase(22, 11, 11)]
        public void GetGreatestCommonDivisorUsingEuclidsAlgo_WhenABPassed_ShouldReturnGreatestCommonDivisorUsingEuclidsAlgo(int a, int b, int expected)
        {
            int actual = Cycles.GetGreatestCommonDivisorUsingEuclidsAlgo(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(8, 2)]
        [TestCase(27,3)]
        public void GetNumberUsingTheHalfDivisionMethod_WhenNumberPassed_ShouldReturnNumberUsingTheHalfDivisionMethod(int number, int expected)
        {
            int actual = Cycles.GetNumberUsingTheHalfDivisionMethod(number);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(11, 2)]
        [TestCase(1121, 3)]
        [TestCase(222, 0)]
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

        [TestCase(10, new int[] {2,4,6,8 })]
        [TestCase(2, new int[] { 2})]
        [TestCase(16, new int[] { 2, 4, 6, 8,12,14,16 })]
        public void GetNumbersSumOfEvenDigitsIsGreaterSumOdd_WhenNumberPassed_ShouldReturnNumbersSumOfEvenDigitsIsGreaterSumOdd(int number, int[] expectedArr)
        {
            int[] actualArr = Cycles.GetNumbersSumOfEvenDigitsIsGreaterSumOdd(number);

            Assert.AreEqual(expectedArr, actualArr);
        }

        [TestCase(44,40,true)]
        [TestCase(222,111,false)]
        [TestCase(1,101,true)]
        public void GetTrueOrFalseIfNumbersHaveSameDigits_WhenNumberPassed_ShouldReturn1Or0(int firstNum, int secondNum, bool expected)
        {
            bool actual = Cycles.GetTrueOrFalseIfNumbersHaveSameDigits(firstNum, secondNum);

            Assert.AreEqual(expected, actual);
        }
        

    }

}