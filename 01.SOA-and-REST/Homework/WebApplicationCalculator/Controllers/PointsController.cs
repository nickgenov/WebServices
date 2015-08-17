using System;
using System.Web.Http;

namespace WebApplicationCalculator.Controllers
{
    public class PointsController : ApiController
    {
        public double Post(int startX, int startY, int endX, int endY)
        {
            int deltaX = startX - endX;
            int deltaY = startY - endY;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            return distance;
        }
    }
}