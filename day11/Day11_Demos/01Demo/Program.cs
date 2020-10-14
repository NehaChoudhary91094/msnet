using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Linq.Expressions;

namespace _01Demo
{
    //public delegate bool MyDelegate(int i);
    //public delegate Q MyDelegate<Q,T>(T i);
    class Program
    {
        static void Main(string[] args)
        {

            //MyDelegate<bool, int> pointer = new MyDelegate<bool, int>(Check);
            //MyDelegate<bool, int> pointer = delegate (int i)
            //                                    {
            //                                        return (i > 10);
            //                                    };

            //Func<int, bool> pointer = delegate (int i)
            //                            {
            //                                return (i > 10);
            //                            };


            //Func<int, bool> pointer =  (i)=> { return (i > 10); };


            //Stage 1: Create Expression Tree 
            Expression< Func<int, bool>> tree = (i) =>  (i > 10);

            //Stage 2: Compile Epxression Tree
            Func<int, bool> pointer = tree.Compile();

            Stopwatch watch = new Stopwatch();
            watch.Start();

            //bool result = Check(100);
            //Below: is Stage 3 in case of Expression Tree i.e. Execute Tree
            bool result = pointer(100); 

            watch.Stop();

            Console.WriteLine("Time Taken = " + watch.ElapsedTicks.ToString());
            Console.WriteLine("Result is " + result);

            Console.ReadLine();
        }

        


        //public static bool Check(int i)
        //{
        //    return (i > 10);
        //}
    }

    
}
