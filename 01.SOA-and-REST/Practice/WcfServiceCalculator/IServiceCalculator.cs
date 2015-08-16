using System.ServiceModel;

namespace WcfServiceCalculator
{
    [ServiceContract]
    public interface IServiceCalculator
    {
        [OperationContract]
        long SumNumbers(int a, int b);

        [OperationContract]
        double DivideNumbers(int a, int b);
    }
}