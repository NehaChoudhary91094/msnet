using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignment
{
   public delegate string MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            //You can use this main method for solution of the problem statement

            A aObj = new A();
            B bobj = new B();

            MyDelegate pointer = new MyDelegate(bobj.M2);

            aObj.M1(pointer);
        }
    }

    public class A
    {
        //You can pass one parameter to M1
        //but parameter shoud not be of type string
        //parameter shoud not be of type  B 
        //parameter shoud not be of type Object
        public void M1(MyDelegate pointer) 
        {
            Console.WriteLine(pointer());
            // Here you will have to call M2 method from B class
            //and print here what M2 returns on the screen..


            // but conditions are: Here in this code of M1
            // 1. You wil not declare B Object
            // 2. No usage of Generics / Inheritance / Overloading  OverRiding 
            // 3. No Usage of Static / abstract / singletone
            // 4. No Usage of Collections
            // 5. No Events
            // 6. No File Io / Serialization
            // 7. No Partial Class, Nullbale Type, Anonymous Method, Lambada Expression to be used 
            // 8. No DLL Concept
            
        }
    }

    public class B
    {
        public string M2()
        {
            return "M2 from  B";
        }
    }
}
