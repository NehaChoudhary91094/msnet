using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consumer2.Proxy;

namespace Consumer2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataWebServiceSoapClient proxyObj = new DataWebServiceSoapClient();
            int result = proxyObj.Add(10, 20);
            Console.WriteLine(result);
        }
    }
}
