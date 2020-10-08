using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Normal File Writing
            //FileStream fs = new FileStream(@"E:\PuneDAC\Day07\Data.txt", 
            //                                FileMode.OpenOrCreate, 
            //                                FileAccess.Write);

            //StreamWriter writer = new StreamWriter(fs);

            //writer.WriteLine("Hello All!");

            //fs.Flush();
            //writer.Close();
            //fs.Close();
            #endregion

            #region Normal File Reading
            //FileStream fs = new FileStream(@"E:\PuneDAC\Day07\Data.txt",
            //                                FileMode.Open,
            //                                FileAccess.Read);

            //StreamReader reader = new  StreamReader(fs);

            ////while (true)
            ////{
            ////    string entireData = reader.ReadLine();
            ////    if (entireData!=null)
            ////    {
            ////        Console.WriteLine(entireData);
            ////    }
            ////    else
            ////    {
            ////        break;
            ////    }
            ////}



            //string entireData = reader.ReadToEnd();
            //Console.WriteLine(entireData);

            //reader.Close();
            //fs.Close();
            #endregion

            #region Normal File Writing

            //Emp emp = new Emp();

            //Console.WriteLine("Enter No:");
            //emp.No = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Name");
            //emp.Name = Console.ReadLine();


            //FileStream fs = new FileStream(@"E:\PuneDAC\Day07\Data.txt",
            //                                FileMode.OpenOrCreate,
            //                                FileAccess.Write);

            //StreamWriter writer = new StreamWriter(fs);

            //writer.WriteLine(emp);

            //fs.Flush();
            //writer.Close();
            //fs.Close();
            #endregion


        }
    }

    public class Emp
    {
        private int _No;
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int No
        {
            get { return _No; }
            set { _No = value; }
        }

        public string getDetails()
        {
            return No.ToString() + " - " + Name;
        }

    }
}
