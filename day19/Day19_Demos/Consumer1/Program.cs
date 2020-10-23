using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consumer1.Proxy;
namespace Consumer1
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorSoapClient proxyObj = new CalculatorSoapClient();
            int result = proxyObj.Add(10, 20);
            Console.WriteLine(result);
        }
    }
}
