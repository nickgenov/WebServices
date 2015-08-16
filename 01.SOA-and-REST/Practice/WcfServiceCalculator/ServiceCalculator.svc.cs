using System;

namespace WcfServiceCalculator
{
    public class ServiceCalculator :IServiceCalculator
    {
        public long SumNumbers(int a, int b)
        {
            return a + b;
        }

        public double DivideNumbers(int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("Cannot divide numbers");
            }
            return (double) a / b;
        }
    }
}