using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCalculator
{
    public static  class Calculator
    {
        public static double Add(double left, double right)
        {
            return left + right;
        }

        public static double Multiply(double left, double right)
        {
            return left * right;
        }

        public static double Divide(double left, double right)
        {
            var res = left / right;
            return res;
        }

        public static double Subtract(double left, double right)
        {
            var res = left - right;
            return res;
        }
    }
}
