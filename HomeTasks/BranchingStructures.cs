using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTasks
{
    public class BranchingStructures
    {
        public static int CompareTwoValuesAndReturnAPlusBOrAMultiBOrAMinusB (int a, int b)
        {
            int result;

            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }

            return result;
        }

        public static int GetQuarter(int x, int y)
        {
            int result;

            if (!(x == 0 || y == 0))
            {
                if (x > 0)
                {
                    if (y > 0)
                    {
                        result = 1;
                    }
                    else
                    {
                        result = 4;
                    }
                }
                else
                {
                    if (y > 0)
                    {
                        result = 2;
                    }
                    else
                    {
                        result = 3;
                    }
                }
            }
            else
            {
                throw new ArgumentException("Point does not belong to any of the quarters");
            }

            return result;
        }

        public static void GetAscendingOrder(ref int a, ref int b, ref int c)
        {
            int temp;
            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;

            }
            if (a > c)
            {
                temp = a;
                a = c;
                c = temp;
            }
            if (b > c)
            {
                temp = b;
                b = c;
                c = temp;
            }
        }

        public static double[] GetSolutionQuadraticEquation(int a, int b, int c)
        {
            if (!(a == 0))
            {
                double x1;
                double x2;
                double d = b * b - 4 * a * c;

                if (d > 0)
                {
                    x1 = (-b - Math.Sqrt(d)) / (2 * a);
                    x2 = (-b + Math.Sqrt(d)) / (2 * a);
                    return new double[] { Math.Round(x1,3),Math.Round(x2,3)};
                }
                else if (d == 0)
                {
                    x1 = -b / (2 * a);
                    return new double[] {Math.Round(x1,3)};
                }
                else
                {
                    return new double[] { } ;
                }
               
            }
            throw new DivideByZeroException("'A' not equal zero");
        }

        public static string GetUppercaseNumber(int number)
        {
            if (!(number < 10 || number > 100))
            {
                string uppercaseNumber = string.Empty;
                int numeral1 = number / 10;
                int numeral2 = number % 10;
                if (numeral1 == 1)
                {
                    switch (number)
                    {
                        case 10:
                            uppercaseNumber = "десять";
                            break;
                        case 11:
                            uppercaseNumber = "оддинадцать";
                            break;
                        case 12:
                            uppercaseNumber = "двенадцать";
                            break;
                        case 13:
                            uppercaseNumber = "тринадцать";
                            break;
                        case 14:
                            uppercaseNumber = "четырнадцать";
                            break;
                        case 15:
                            uppercaseNumber = "пятнадцать";
                            break;
                        case 16:
                            uppercaseNumber = "шестнадцать";
                            break;
                        case 17:
                            uppercaseNumber = "семнадцать";
                            break;
                        case 18:
                            uppercaseNumber = "восемнадцать";
                            break;
                        case 19:
                            uppercaseNumber = "девятнадцать";
                            break;

                    }
                }
                else
                {
                    switch (numeral1)
                    {
                        case 2:
                            uppercaseNumber = "Двадцать";
                            break;
                        case 3:
                            uppercaseNumber = "Тридцать";
                            break;
                        case 4:
                            uppercaseNumber = "Сорок";
                            break;
                        case 5:
                            uppercaseNumber = "Пятьдесят";
                            break;
                        case 6:
                            uppercaseNumber = "Шестьдесят";
                            break;
                        case 7:
                            uppercaseNumber = "Семьдесят";
                            break;
                        case 8:
                            uppercaseNumber = "Восемьдесят";
                            break;
                        case 9:
                            uppercaseNumber = "Девяносто";
                            break;

                    }

                    if (numeral2 != 0)
                    {
                        switch (numeral2)
                        {
                            case 1:
                                uppercaseNumber += " один";
                                break;
                            case 2:
                                uppercaseNumber += " два";
                                break;
                            case 3:
                                uppercaseNumber += " три";
                                break;
                            case 4:
                                uppercaseNumber += " четыре";
                                break;
                            case 5:
                                uppercaseNumber += " пять";
                                break;
                            case 6:
                                uppercaseNumber += " шесть";
                                break;
                            case 7:
                                uppercaseNumber += " семь";
                                break;
                            case 8:
                                uppercaseNumber += " восемь";
                                break;
                            case 9:
                                uppercaseNumber += " девять";
                                break;
                        }
                    }
                }

                return uppercaseNumber;
               
            }

            throw new Exception("Please enter a two-digit number");
        }

    }
}
