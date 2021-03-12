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
        public void ResultEquation_WhenABPassed_ShouldReturnArgumentException(int a, int b)
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

        [TestCase(4, 0)]
        public void DivisionAndRemainder_WhenABPassed_ShouldReturnDivideByZeroException(int a, int b)
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                double actualDivision = 0;
                int actualRemainder = 0;

                Variables.GetDivisionAndRemainder(a, b, ref actualDivision, ref actualRemainder);
            });
        }

        [TestCase(2, 2, 2, 0)]
        [TestCase(1, 8, 10, 2)]
        [TestCase(4, 3, 12, 2.25)]
        public void LinearEquation_WhenABCPassed_ShouldReturnResultLinearEquation(int a, int b, int c, double expected)
        {
            double actual = Variables.GetSolutionLinearEquation(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 2, 3)]
        public void LinearEquation_WhenABCPassed_ShouldReturnDivideByZeroException(int a, int b, int c)
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                double actual = Variables.GetSolutionLinearEquation(a, b, c);
            });
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

        [TestCase(3, 2, 3, 1)]
        public void EquationOfStraightLine_WhenX1Y1X2Y2Passed_ShouldReturnArgumentException(double x1, double y1, double x2, double y2)
        {

            Assert.Throws<ArgumentException>(() =>
            {
                double[] actualArr = Variables.GetEquationOfStraightLine(x1, y1, x2, y2);
            });

        }

    }
}
