using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Readify
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IReadify" in both code and config file together.
    [ServiceContract(Namespace = "http://KnockKnock.readify.net", Name = "IReadify")]
    public interface IReadify
    {
        [OperationContract]
        Guid Token();
        [OperationContract]
        long Fibonacci(long n);
        [OperationContract]
        string ReverseWords(string s);
        [OperationContract]
        TriangleTypes TriangleType(int a, int b, int c);
    }

    [DataContract]
    public enum TriangleTypes
    {
        [EnumMember]
        Error,
        [EnumMember]
        Equilateral,
        [EnumMember]
        Isosceles,
        [EnumMember]
        Scalene
    }
}
