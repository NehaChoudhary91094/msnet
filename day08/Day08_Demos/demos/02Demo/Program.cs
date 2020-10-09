using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Swap of Integers
            //Maths obj = new Maths();

            //int p = 100;
            //int q = 200;
            //Console.WriteLine("Before Swap p = " + p.ToString() + " and q = " + q.ToString());

            //obj.Swap(ref p,ref q);

            //Console.WriteLine("After Swap p = " + p.ToString() + " and q = " + q.ToString());

            //Console.ReadLine();
            #endregion

            #region Swap of Integers and Double
            //Maths<int> obj1 = new Maths<int>();

            //int p1 = 10;
            //int q1 = 20;
            //Console.WriteLine("Before Swap p1 = " + p1.ToString() + " and q1 = " + q1.ToString());

            //obj1.Swap(ref p1, ref q1);

            //Console.WriteLine("After Swap p1 = " + p1.ToString() + " and q1 = " + q1.ToString());



            //Maths<double> obj = new Maths<double>();

            //double p = 10.55;
            //double q = 20.11;
            //Console.WriteLine("Before Swap p = " + p.ToString() + " and q = " + q.ToString());

            //obj.Swap(ref p, ref q);

            //Console.WriteLine("After Swap p = " + p.ToString() + " and q = " + q.ToString());

            //Console.ReadLine();
            #endregion

            #region Normal class with generic method
            //Maths obj = new Maths();
            //int result = obj.Add(10, 20);
            //Console.WriteLine(result);

            //int p1 = 10;
            //int q1 = 20;
            //Console.WriteLine("Before Swap p1 = " + p1.ToString() + " and q1 = " + q1.ToString());

            //obj.Swap<int>(ref p1, ref q1);

            //Console.WriteLine("After Swap p1 = " + p1.ToString() + " and q1 = " + q1.ToString());
            #endregion

            #region Using Normal Derived Class object to call Generic Base Class Method
            //SpecialMaths sm = new SpecialMaths();
            //double p = 10.55;
            //double q = 20.11;
            //Console.WriteLine("Before Swap p = " + p.ToString() + " and q = " + q.ToString());

            //sm.Swap(ref p, ref q);

            //Console.WriteLine("After Swap p = " + p.ToString() + " and q = " + q.ToString());

            //Console.ReadLine(); 
            #endregion

            #region using generic method accepting and returning multiple Generic parameters
            //SpecialMaths<int, double, short, string> obj =
            //   new SpecialMaths<int, double, short, string>();
            //string data = obj.DoSomething(100, 20.2, 2, "abcd");
            //Console.WriteLine(data);
            #endregion
        }
    }

    #region Generic Class (Maths) with Generic(Swap) & Normal Method(Add)
    //public class Maths<T>
    //{

    //    public void Swap(ref T x, ref T y)
    //    {
    //        T z;
    //        z = x;
    //        x = y;
    //        y = z;
    //    }


    //    public int Add(int x, int y)
    //    {
    //        return x + y;
    //    }
    //}
    #endregion

    #region Normal Class (maths)with Genric(Swap) & Normal Method(Add)
    //public class Maths
    //{

    //    public void Swap<T>(ref T x, ref T y)
    //    {
    //        T z;
    //        z = x;
    //        x = y;
    //        y = z;
    //    }


    //    public int Add(int x, int y)
    //    {
    //        return x + y;
    //    }
    //}
    #endregion

    #region Normal Class (SpecialMaths)Inheriting from Generic Class (Maths) with T as hardcoded double
    //public class Maths<T>
    //{
    //    public void Swap(ref T x, ref T y)
    //    {
    //        T z;
    //        z = x;
    //        x = y;
    //        y = z;
    //    }
    //}

    //public class SpecialMaths:Maths<double>
    //{

    //}
    #endregion

    #region Generic Class ( SpecialMaths) inheriting another generic Class (Maths)
    //public class Maths<T>
    //{
    //    public void Swap(ref T x, ref T y)
    //    {
    //        T z;
    //        z = x;
    //        x = y;
    //        y = z;
    //    }
    //}

    //public class SpecialMaths<P,Q,R,S> : Maths<R>
    //{
    //    public S DoSomething(P p , Q q, R r, S s)
    //    {
    //        return s;
    //    }
    //}
    #endregion
}
