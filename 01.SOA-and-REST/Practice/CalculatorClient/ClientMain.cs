using System;
using CalculatorClient.ServiceReferenceCalc;

namespace CalculatorClient
{
    class ClientMain
    {
        static void Main()
        {
            var client = new ServiceCalculatorClient();

            long result = client.SumNumbers(5, 7);
            Console.WriteLine(result);
        }
    }
}