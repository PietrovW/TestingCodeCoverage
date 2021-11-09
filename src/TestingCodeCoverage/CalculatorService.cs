﻿using System;

namespace TestingCodeCoverage
{
    public class CalculatorService
    {
        public static Double Add(double x, double y)
        {
            return x + y;
        }

        public static Double Subtract(double x, double y)
        {
            return x - y;
        }

        public static Double Multiply(double x, double y)
        {
            return x * y;
        }

        public static Double Divide(double x, double y)
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                return 0;
            }

        }
       
    }
}