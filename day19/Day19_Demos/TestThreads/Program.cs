using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
namespace TestThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Emp> emps = new List<Emp>() { 
            new Emp(){  No = 11, Name = "mahesh1"},
            new Emp(){  No = 12, Name = "mahesh2"},
            new Emp(){  No = 13, Name = "mahesh3"},
            new Emp(){  No = 14, Name = "mahesh4"},
            new Emp(){  No = 15, Name = "mahesh5"},
            new Emp(){  No = 16, Name = "mahesh6"},
            new Emp(){  No = 17, Name = "mahesh7"},
            new Emp(){  No = 18, Name = "mahesh8"}

            };

            var result = from emp in emps.AsParallel()
                         where emp.No > 15
                         select emp;


            //foreach (Emp emp in emps)
            //{
            //    Console.WriteLine("Thread executing this code {0}", Thread.CurrentThread.ManagedThreadId);
            //    Console.WriteLine(emp.Name);

            //}

            Parallel.ForEach(emps, emp => 
                                    {
                                        Console.WriteLine("Thread executing this code {0}", Thread.CurrentThread.ManagedThreadId);
                                            Console.WriteLine(emp.Name);
                                    });


            //Stopwatch watch = new Stopwatch();
            //watch.Start();

            

            //for (int i = 0; i < 10; i++)
            //{
            //    //Thread t = new Thread(DoSomeThingVeryComplex);
            //    //t.Start();

            //    //Task t = new Task(DoSomeThingVeryComplex);
            //    //t.Start();


            //    //DoSomeThingVeryComplex();
            //}

            //Task.WaitAll();
            //watch.Stop();
            //Console.WriteLine("Total Time taken = {0}", watch.ElapsedMilliseconds);
            Console.ReadLine();
        }

        static void DoSomeThingVeryComplex()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();


            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {

                }
            }
            watch.Stop();
            Console.WriteLine("Time taken by Thread No{1} = {0}", watch.ElapsedMilliseconds, Thread.CurrentThread.ManagedThreadId);

            Console.WriteLine("Thread No Executing Code {0}", Thread.CurrentThread.ManagedThreadId);
        }
    }

    public class Emp
    {
        public int No { get; set; }
        public string Name { get; set; }
    }
}
