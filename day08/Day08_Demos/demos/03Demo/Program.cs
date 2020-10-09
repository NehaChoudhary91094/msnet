using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Collections;
using System.Xml.Serialization;

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

            #region Binary Serialization

            //Emp emp = new Emp();

            //Console.WriteLine("Enter No:");
            //emp.No = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Name");
            //emp.Name = Console.ReadLine();


            //FileStream fs = new FileStream(@"E:\PuneDAC\Day08\Data.txt",
            //                                FileMode.OpenOrCreate,
            //                                FileAccess.Write);

            //BinaryFormatter specialwriter = new BinaryFormatter();

            //specialwriter.Serialize(fs, emp);

            //specialwriter = null;
            //fs.Flush();

            //fs.Close();
            #endregion

            #region Binary De-Serialization

            //FileStream fs = new FileStream(@"E:\PuneDAC\Day08\Data.txt",
            //                                FileMode.Open,
            //                                FileAccess.Read);

            //BinaryFormatter specialReader = new BinaryFormatter();

            //object obj = specialReader.Deserialize(fs);
            //if (obj is Emp)
            //{
            //    Emp e = (Emp)obj;
            //    Console.WriteLine(e.getDetails());
            //}
            //else
            //{
            //    Console.WriteLine("Unknown type of data!!");
            //}

            //specialReader = null;
            //fs.Flush();

            // fs.Close();
            #endregion

            #region Binary Serialization of ArrayList

            //Emp emp = new Emp();

            //Console.WriteLine("Enter No:");
            //emp.No = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Name");
            //emp.Name = Console.ReadLine();

            //Book b = new Book();

            //Console.WriteLine("Enter ISBN:");
            //b.ISBN = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Title");
            //b.Title = Console.ReadLine();

            //ArrayList arr = new ArrayList();
            //arr.Add(emp);
            //arr.Add(b);

            //FileStream fs = new FileStream(@"E:\PuneDAC\Day08\Data.txt",
            //                                FileMode.OpenOrCreate,
            //                                FileAccess.Write);

            //BinaryFormatter specialwriter = new BinaryFormatter();

            //specialwriter.Serialize(fs, arr);

            //specialwriter = null;
            //fs.Flush();

            //fs.Close();
            #endregion

            #region Binary De-Serialization of ArrayList

            //FileStream fs = new FileStream(@"E:\PuneDAC\Day08\Data.txt",
            //                                FileMode.Open,
            //                                FileAccess.Read);

            //BinaryFormatter specialReader = new BinaryFormatter();

            //object obj = specialReader.Deserialize(fs);
            //if (obj is ArrayList)
            //{
            //    ArrayList arr = (ArrayList)obj;
            //    foreach (object o in arr)
            //    {
            //        if (o is Emp)
            //        {
            //            Emp e = (Emp)o;
            //            Console.WriteLine(e.getDetails());
            //        }
            //        else if (o is Book)
            //        {
            //            Book b = (Book)o;
            //            Console.WriteLine("Details of the book : " + b.Title);
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Unknown type of data!!");
            //}

            //specialReader = null;
            //fs.Flush();

            //fs.Close();
            #endregion

            #region XML Serialization

            //Emp emp = new Emp();

            //Console.WriteLine("Enter No:");
            //emp.No = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Name");
            //emp.Name = Console.ReadLine();


            //FileStream fs = new FileStream(@"E:\PuneDAC\Day08\Data.xml",
            //                                FileMode.OpenOrCreate,
            //                                FileAccess.Write);

            //XmlSerializer specialwriter = new XmlSerializer(typeof(Emp));

            //specialwriter.Serialize(fs, emp);

            //specialwriter = null;
            //fs.Flush();

            //fs.Close();
            #endregion

            #region XML De-Serialization

            //FileStream fs = new FileStream(@"E:\PuneDAC\Day08\Data.xml",
            //                                FileMode.Open,
            //                                FileAccess.Read);

            //XmlSerializer specialReader = new XmlSerializer(typeof(Emp));

            //object obj = specialReader.Deserialize(fs);
            //if (obj is Emp)
            //{
            //    Emp e = (Emp)obj;
            //    Console.WriteLine(e.getDetails());
            //}
            //else
            //{
            //    Console.WriteLine("Unknown type of data!!");
            //}

            //specialReader = null;
            //fs.Flush();

            //fs.Close();
            #endregion

            #region SOAP Serialization

            //Emp emp = new Emp();

            //Console.WriteLine("Enter No:");
            //emp.No = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Name");
            //emp.Name = Console.ReadLine();


            //FileStream fs = new FileStream(@"E:\PuneDAC\Day08\DataSOAP.xml",
            //                                FileMode.OpenOrCreate,
            //                                FileAccess.Write);

            //SoapFormatter specialwriter = new  SoapFormatter();

            //specialwriter.Serialize(fs, emp);

            //specialwriter = null;
            //fs.Flush();

            //fs.Close();
            #endregion

            #region SOAP De-Serialization

            //FileStream fs = new FileStream(@"E:\PuneDAC\Day08\DataSOAP.xml",
            //                                FileMode.Open,
            //                                FileAccess.Read);

            //SoapFormatter specialReader = new SoapFormatter();

            //object obj = specialReader.Deserialize(fs);
            //if (obj is Emp)
            //{
            //    Emp e = (Emp)obj;
            //    Console.WriteLine(e.getDetails());
            //}
            //else
            //{
            //    Console.WriteLine("Unknown type of data!!");
            //}

            //specialReader = null;
            //fs.Flush();

            //fs.Close();
            #endregion

        }
    }

    [Serializable]
    public class Emp
    {
        [NonSerialized]
        private string _Password = "mahesh@123";
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

    [Serializable]
    public class Book
    {
        private string _Title;
        private int _ISBN;

        public int ISBN
        {
            get { return _ISBN; }
            set { _ISBN = value; }
        }

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

    }
}
