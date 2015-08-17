using System.Runtime.Serialization;

namespace WcfServiceCalculator
{
    [DataContractAttribute]
    public class Point
    {
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        [DataMember]
        public int X { get; set; }
        [DataMember]
        public int Y { get; set; }
    }
}