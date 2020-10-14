using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace _00Demo
{
    delegate string MyDelegate(string name);
 
    class Program
    {
        static void Main(string[] args)
        {
            #region Partial Class Usage
            //Maths obj = new Maths();

            //Console.WriteLine(obj.Add(10, 20));
            //Console.WriteLine(obj.Sub(10, 20));
            //Console.WriteLine(obj.Mult(10, 20));
            #endregion

            #region Nullable Type
            // Nullable<int> Salary = null;

            //// int? Salary = null; //???
            // if (Salary.HasValue)
            // {
            //     Console.WriteLine("Salary holds a value");
            // }
            // else
            // {
            //     Console.WriteLine("Salary is NULL");
            // }
            #endregion

            #region Anonymous Method
            //Call Normal Method
            //string message = SayHello("mahesh");
            //Console.WriteLine(message);

            //Call method using pointer
            //MyDelegate pointer = new MyDelegate(SayHello);
            //string message = pointer("mahesh");
            //Console.WriteLine(message);

            //Call method which is anonymous
            //MyDelegate pointer = delegate(string name)
            //                                {
            //                                    return "Hello " + name;
            //                                };
            //string message = pointer("mahesh");
            //Console.WriteLine(message);
            #endregion

            #region Lambada Expression
            ////used for explaining Lambada Expession Syntax
            ////MyDelegate pointer = new MyDelegate(SayHello);
            ////string message = pointer("mahesh");
            ////Console.WriteLine(message);

            //Lambada Expession Syntax
            //MyDelegate pointer =  (nm)=>{  return "Hello " + nm; };
            //string message = pointer("mahesh");
            //Console.WriteLine(message);
            #endregion

            #region Iterator
            //Week week = new Week();

            //foreach (string day in week)
            //{
            //    Console.WriteLine(day);
            //}

            //List<int> arr = new List<int>();
            //foreach (int i in arr)
            //{

            //}
            #endregion

            #region Implicit Type (VAR)
            //int choice = Convert.ToInt32(Console.ReadLine());
            //var v = GetSomething(choice);

            //var v1= 100;
            ////v = "anything";//This generates err

            ////var v2 = new Emp();

            #endregion

            #region Auto Property
            //Emp emp = new Emp();
            ////Using Auto Property For Assignment
            //emp.No = 100;
            //emp.Name = "mahesh";
            //emp.Address = "Pune";

            ////Using Normal Property For Assignment
            //emp.Age = 40;

            //Console.WriteLine(emp.Name); 
            #endregion

            #region Object Initializer
            //Object Initializer Syntax
            //var emp = new Emp() {No = 100, Name = "mahesh", Age = 40 };
            //Console.WriteLine(emp.Name);
            #endregion

            #region Anonymous Type
            //var obj1 = new {No = 100, Name = "mahesh", Age = 40 };

            //var obj2 = new { No = 100, Name = 1234, Age = "Forty" };

            //var obj3= new { No = 100, Age = 40 , Name = "mahesh"};


            //Console.WriteLine(obj.Name);
            #endregion

            #region Extension Method
            //Console.WriteLine("Enter some data");
            //string data = Console.ReadLine();

            //MyUtilityClass obj = new MyUtilityClass();
            //bool result =  obj.CheckForValidEMailAddress(data);

            //bool result = MyUtilityClass.CheckForValidEMailAddress(data,100);

            //bool result = data.CheckForValidEMailAddress(100);

            //Console.WriteLine(result);

            //int[] arr = new int[] { 10, 20, 30, 40, 50, 60 };
            //Console.WriteLine(arr.Average());

            //var v = new { No = 1, Name = "mahesh", Address = "pune" };
            //v.CheckForValidEMailAddress(8);
            #endregion



        }

        public static object GetSomething(int i)
        {
            if (i ==1)
            {
                return 100;
            }
            else
            {
                return new object();
            }

        }

        //public void SomeMethod(var v1, var v2)
        //{

        //}

        //public static string SayHello(string name)
        //{
        //    return "Hello " + name;
        //}
    }

    #region Writing Extension Methods
    public static class MyUtilityClass
    {
        public static bool CheckForValidEMailAddress<T>(this T str, int i)
        {
            return true;
        }
        public static bool CheckForValidEMailAddress(this string str, int i)
        {
            return str.Contains("@");
        }
    }
    #endregion


    public class Week: IEnumerable
    {
        private string[] days = 
            new string[] {"Mon","Tue", "Wed", "Thur", "Fri", "Sat", "Sun" };

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < days.Length; i++)
            {
                yield return days[i];
            }
        }
    }

    //public class Emp
    //{
    //    private int _Age;

    //    public int Age
    //    {
    //        get { return _Age; }
    //        set { _Age = value; }
    //    }


    //    public int No { get; set; }
    //    public string Name { get; set; }
    //    public string Address { get; set; }
    //}
    //public class Emp
    //{
    //    private string _Name;
    //    private bool _IsConsultant;
    //    private string _Address;

    //    public string Addrress
    //    {
    //        get { return _Address; }
    //        set { _Address = value; }
    //    }

    //    public bool IsConsultant
    //    {
    //        get { return _IsConsultant; }
    //        set { _IsConsultant = value; }
    //    }

    //    public string Name
    //    {
    //        get { return _Name; }
    //        set { _Name = value; }
    //    }


    //}

    #region Sealed Class
    public class A
    {
        public virtual void M1()
        {

        }
    }


    public class B : A
    {
        //public sealed override void M1()
        //{

        //}
    }

    public class C : B
    {
        //Not allowed to override
        //public override void M1()
        //{

        //}
    }
    #endregion
}

