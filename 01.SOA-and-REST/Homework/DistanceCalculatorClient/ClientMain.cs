using System;
using DistanceCalculatorClient.ServiceReferenceDistanceCalculator;

namespace DistanceCalculatorClient
{
    class ClientMain
    {
        static void Main()
        {
            Point a = new Point()
            {
                X = 5,
                Y = 11
            };

            Point b = new Point()
            {
                X = 10,
                Y = 12
            };

            using (var client = new ServiceCalculatorClient())
            {
                double result = client.CalcDistance(a, b);
                Console.WriteLine(result);
            }
        }
    }
}