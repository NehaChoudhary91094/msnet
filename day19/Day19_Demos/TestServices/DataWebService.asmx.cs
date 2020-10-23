using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TestServices
{
    [WebService]
    public class DataWebService : WebService
    {
        [WebMethod]
        public int Add(int x, int y)
        {
            return x + y;
        }

        [WebMethod]
        public int Sub(int x, int y)
        {
            return x - y;
        }
    }
}
