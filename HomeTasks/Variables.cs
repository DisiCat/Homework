using System;

namespace HomeTasks
{
    public class Variables
    {
        public static int GetResultEquation(int a, int b)
        {
            if (b - a != 0)
            {
                return (5 * a + b * b) / (b - a);
            }

            throw new ArgumentException(" b does not equal a ");
        }

        public static void SwapValueOfVariables(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        public static void GetDivisionAndRemainder(int a, int b, ref double division, ref int remainder)
        {
            if (b != 0)
            {
                division = Convert.ToDouble(a) / Convert.ToDouble(b);
                remainder = a % b;
            }
            else
            {
                throw new DivideByZeroException("b is not equal to zero");
            }
        }

        public static double GetSolutionLinearEquation(int a, int b, int c)
        {
            if (a != 0)
            {
                return Convert.ToDouble(c - b) / Convert.ToDouble(a);
            }
            throw new DivideByZeroException(" a not equal zero");
        }

        public static double[] GetEquationOfStraightLine(double x1, double y1, double x2, double y2)
        {
            if (!(x1 - x2 == 0))
            {
                double a =(y1 - y2) / (x1 - x2);
                double b = y2 - a * x2;
                return new double[] { Math.Round(a,3), Math.Round(b,3) };
            } 
                throw new ArgumentException(" x1 not equal x2 ");
        }
    
    }
}
