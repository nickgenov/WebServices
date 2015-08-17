using System.ServiceModel;

namespace WcfServiceCalculator
{
    [ServiceContract]
    public interface IServiceCalculator
    {
        [OperationContract]
        double CalcDistance(Point startPoint, Point endPoint);
    }
}