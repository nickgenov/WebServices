using System;
using System.Net;

namespace RestClient
{
    class ClientMain
    {
        static void Main()
        {
            using (var client = new WebClient())
            {
                var response = client.UploadString(
                    "http://localhost:11339/api/points?startX=5&startY=5&endX=12&endY=12", "POST", "");

                Console.WriteLine(response);
            }
        }
    }
}