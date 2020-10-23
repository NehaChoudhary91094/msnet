using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace TestServices
{
    [ServiceContract]
    public interface IDBService
    {
        string SayHi(string msg);

        [OperationContract]
        List<Emp> GetEmps();

    }
}
