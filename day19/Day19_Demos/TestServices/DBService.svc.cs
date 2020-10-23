using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TestServices
{

    public class DBService : IDBService
    {
        public List<Emp> GetEmps()
        {
            SunbeamDBEntities dbObj = new SunbeamDBEntities();
            return dbObj.Emps.ToList();
        }

        public string SayHi(string msg)
        {
            return "Hi " + msg;
        }
    }
}
