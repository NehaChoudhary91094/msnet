using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace _01Demo.DAL
{
    public class DBFactory
    {
        public IDatabase GetDatabase()
        {
            int dbchoice = Convert.ToInt32(ConfigurationManager.AppSettings["dbchoice"]);

            if (dbchoice == 1)
            {
                return new SQLServer();
            }
            else
            {
                return new Oracle();
            }
        }
    }
}
