using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
namespace TestEventsDelegates
{
    //Code Written by Shweta
    //Shweta has purchased DLL written by Mahesh
    //assuming DLL is also referred into current project
    class Program
    {
        static void Main(string[] args)
        {
            SQLServer dbObj = new SQLServer();

            mydelegate pointer1 = new mydelegate(OnInsertCallMe);
            mydelegate pointer2 = new mydelegate(OnUpdateCallMe);
            mydelegate pointer3 = new mydelegate(OnDeleteCallMe);

            dbObj.Inserted += pointer1;
            dbObj.Updated += pointer2;
            dbObj.Deleted += pointer3;


            dbObj.Insert("abcd");
            dbObj.Update("abcd");
            dbObj.Delete("abcd");

        }

        public static void OnInsertCallMe()
        {
            Console.WriteLine("Logging Insert into Console");
        }

        public static void OnUpdateCallMe()
        {
            Console.WriteLine("Logging Update into Console");
        }

        public static void OnDeleteCallMe()
        {
            Console.WriteLine("Logging Delete into Console");
        }
    }


}

namespace DB
{

     public delegate void mydelegate();

    //Written by Mahesh
    //assume - logic  is compiled into a DLL and sold to various companies
    public class SQLServer
    {
            
        public event mydelegate Inserted;
        public event mydelegate Updated;
        public event mydelegate Deleted;
        public void Insert(string data)
        {
            Console.WriteLine(data  + " inserted into SQL Server");
            //Raise Event .. just like raise trigger in database
            Inserted();
        }

        public void Update(string data)
        {
            Console.WriteLine(data + " updated into SQL Server");
            //Raise Event .. just like raise trigger in database
            Updated();
        }

        public void Delete(string data)
        {
            Console.WriteLine(data + " Delete from SQL Server");
            Deleted();
        }
    }
}