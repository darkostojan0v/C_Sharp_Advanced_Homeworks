using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    public static class Calculations
    {
        public static string CalcSum(double num1, double num2)
        {
            double result = num1 + num2;

            string resultToString = result.ToString();

            return $"{num1} + {num2} = {resultToString}";
        }
    }
}
