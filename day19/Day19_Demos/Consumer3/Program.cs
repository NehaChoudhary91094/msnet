using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consumer3.Proxy;
namespace Consumer3
{
    class Program
    {
        static void Main(string[] args)
        {
            DBServiceClient proxydbObj = new DBServiceClient();
            foreach (var item in proxydbObj.GetEmps())
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
