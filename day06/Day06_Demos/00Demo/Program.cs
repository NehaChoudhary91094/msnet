using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace _00Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Sample Employee Objects Used through out the demo
            Emp e1 = new Emp();
            e1.No = 1;
            e1.Name = "Rajiv";

            Emp e2 = new Emp();
            e2.No = 2;
            e2.Name = "Rahul";

            Emp e3 = new Emp();
            e3.No = 3;
            e3.Name = "Mahesh";
            #endregion

            #region Simple Type Casting
            //Emp e = new Emp();
            //e.No = 100;
            //e.Name = "mahesh";

            //int i = 100;
            ////Object obj = new Object();

            //object obj = i;
            //obj = "abcd";
            //obj = e;

            //if (obj is int)
            //{
            //    int j = Convert.ToInt32(obj);
            //    Console.WriteLine(j);
            //}
            //else if (obj is string)
            //{
            //    string s = Convert.ToString(obj);
            //    Console.WriteLine(s);
            //}
            //else if (obj is Emp)
            //{
            //    Emp e1 = (Emp)obj;
            //    Console.WriteLine(e1.getDetails());
            //    //Emp e2 = obj as Emp;
            //}
            #endregion

            #region Simple Integer Array - I

            //int[] arr = new int[3];
            //arr[0] = 100;
            //arr[1] = 200;
            //arr[2] = 300;
            ////arr[3] = 400;  //Array out of bound exception!!

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //} 
            #endregion

            #region Simple Integer Array - II
            //int[] arr = new int[] { 10,20,30,40,50,60,70,80,90,100 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            #endregion

            #region Emp Array
            //Emp[] employees = new Emp[3];
            //employees[0] = e1;
            //employees[1] = e2;
            //employees[2] = e3;

            //for (int i = 0; i < employees.Length; i++)
            //{
            //    Emp e = employees[i];
            //    Console.WriteLine(e.getDetails());
            //}

            //Console.ReadLine();
            #endregion

            #region Object Array of fixed Size 
            //object[] arr = new object[5];
            //arr[0] = e1;       
            //arr[1] = 100;   //Boxing
            //arr[2] = "abcd";
            //arr[3] = e2;
            //arr[4] = false; //Boxing

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] is int)
            //    {
            //        int k = Convert.ToInt32(arr[i]);//UnBoxing
            //        Console.WriteLine(k);
            //    }
            //    else if (arr[i] is string)
            //    {
            //        string s = Convert.ToString(arr[i]);
            //        Console.WriteLine(s);
            //    }
            //    else if (arr[i] is Emp)
            //    {
            //        Emp e = (Emp)arr[i];
            //        Console.WriteLine(e.getDetails());
            //    }
            //    else if (arr[i] is bool)
            //    {
            //        bool b = Convert.ToBoolean(arr[i]);//UnBoxing
            //        Console.WriteLine(b);
            //    }
            //    else
            //    {
            //        Console.WriteLine("unknown type of data!");
            //    }

            //}
            #endregion

            #region ArrayList: Array of objects .. no limit

            //ArrayList arr = new ArrayList();
            //arr.Add(e1);
            //arr.Add(100);   //Boxing
            //arr.Add("abcd");
            //arr.Add(e2);
            //arr.Add(false); //Boxing
            //arr.Add(e3);
            //arr.Add(10.2);
            //arr.Add(new DateTime());
            //arr.Add(new int[] { 10, 20, 30 });

            //for (int i = 0; i < arr.Count; i++)
            //{
            //    if (arr[i] is int)
            //    {
            //        int k = Convert.ToInt32(arr[i]);//UnBoxing
            //        Console.WriteLine(k);
            //    }
            //    else if (arr[i] is string)
            //    {
            //        string s = Convert.ToString(arr[i]);
            //        Console.WriteLine(s);
            //    }
            //    else if (arr[i] is Emp)
            //    {
            //        Emp e = (Emp)arr[i];
            //        Console.WriteLine(e.getDetails());
            //    }
            //    else if (arr[i] is bool)
            //    {
            //        bool b = Convert.ToBoolean(arr[i]);//UnBoxing
            //        Console.WriteLine(b);
            //    }
            //    else
            //    {
            //        Console.WriteLine("unknown type of data!");
            //    }

            //} 
            #endregion

            #region HashTable: Key-value Pair Collection. key value are objects. no limit
            //Hashtable arr = new Hashtable();
            //arr.Add("a", e1);
            //arr.Add("b", 100);   //Boxing
            //arr.Add("c", "abcd");
            //arr.Add("d", e2);
            //arr.Add("e", false); //Boxing
            //arr.Add("f", e3);
            //arr.Add("g", 10.2);
            //arr.Add("h", new DateTime());
            //arr.Add("i", new int[] { 10, 20, 30 });


            //foreach (object key in arr.Keys)
            //{
            //    Console.WriteLine(key);
            //    object obj = arr[key];
            //    if (obj is int)
            //    {
            //        int k = Convert.ToInt32(obj);//UnBoxing
            //        Console.WriteLine(k);
            //    }
            //    else if (obj is string)
            //    {
            //        string s = Convert.ToString(obj);
            //        Console.WriteLine(s);
            //    }
            //    else if (obj is Emp)
            //    {
            //        Emp e = (Emp)obj;
            //        Console.WriteLine(e.getDetails());
            //    }
            //    else if (obj is bool)
            //    {
            //        bool b = Convert.ToBoolean(obj);//UnBoxing
            //        Console.WriteLine(b);
            //    }
            //    else
            //    {
            //        Console.WriteLine("unknown type of data!");
            //    }

            //}


            ////Console.WriteLine(  "What would you like to Search? pls enter key");
            ////string key = Console.ReadLine();

            ////object obj = arr[key];


            ////for (int i = 0; i < arr.Count; i++)
            ////{
            ////if (obj is int)
            ////{
            ////    int k = Convert.ToInt32(obj);//UnBoxing
            ////    Console.WriteLine(k);
            ////}
            ////else if (obj is string)
            ////{
            ////    string s = Convert.ToString(obj);
            ////    Console.WriteLine(s);
            ////}
            ////else if (obj is Emp)
            ////{
            ////    Emp e = (Emp)obj;
            ////    Console.WriteLine(e.getDetails());
            ////}
            ////else if (obj is bool)
            ////{
            ////    bool b = Convert.ToBoolean(obj);//UnBoxing
            ////    Console.WriteLine(b);
            ////}
            ////else
            ////{
            ////    Console.WriteLine("unknown type of data!");
            ////}

            ////}
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
            return this.No.ToString() + this.Name;
        }

    }
}
