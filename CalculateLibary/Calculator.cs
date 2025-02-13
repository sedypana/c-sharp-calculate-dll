using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLibary
{
    public class Calculator
    {
        public double Sum(double a, double b)
        {
            return a + b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }

        public double Mult(double a, double b)
        {
            return a * b;
        }

        public double Div(double a, double b)
        {
            double ex = 0;
            if (b == 0)
            {
                throw new DivideByZeroException("Деление на ноль невозможно.");
            }
            else
            {
                ex = a / b;
            }
            return ex;
        }

        public double Pow(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double Log(double a, double b)
        {
            return Math.Log(a, b);
        }

        public double Sin(double a)
        {
            return Math.Sin(a);
        }
    }
}
