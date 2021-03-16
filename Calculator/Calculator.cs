using System;

namespace CalculatorLib
{
    public class Calculator
    {

        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        public int Sub(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

        public int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }

        public double Divide(int num1, int num2)
        {
            if(num2 == 0)
            {
                throw new InvalidOperationException();
            }

            double result = num1 / num2;
            return result;
        }

        public int Modulus(int num1, int num2)
        {
            int result = num1%num2;
            return result;
        }
    }
}
