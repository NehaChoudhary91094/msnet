using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the Assembly Path : EXE / DLL built with .NET");
            string pathOfAssembly = Console.ReadLine();

            // @"E:\PuneDAC\Day08\demos\MathsLib\bin\Debug\MathsLib.dll";

            //below code is for loading top level TYPE metadata information from MathsLib.dll
            Assembly assembly = Assembly.LoadFrom(pathOfAssembly);

            //Now we ask assembly object rest of the details....

            Type[] allTypes = assembly.GetTypes();

            object dynamicObject = null;

            
            foreach (Type type in allTypes)
            {
                Console.WriteLine("Type: " + type.Name);
                dynamicObject = assembly.CreateInstance(type.FullName);
                

                MethodInfo[] allMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

                foreach (MethodInfo method in allMethods)
                {
                    Console.Write(method.ReturnType + "  " + method.Name + "  ( ");

                    ParameterInfo[] allParams = method.GetParameters();
                    
                    foreach (ParameterInfo para in allParams)
                    {
                        Console.Write(para.ParameterType.ToString() +  "  " + para.Name + "  "); 
                    }

                    Console.Write(" ) ");
                    Console.WriteLine();

                    object[] allParas = new object[] { 10,20 };

                    object result =  type.InvokeMember(method.Name,
                                        BindingFlags.Public |
                                        BindingFlags.Instance |
                                        BindingFlags.InvokeMethod,
                                        null, dynamicObject, allParas);

                    Console.WriteLine("Result of " + method.Name + " executed is " + result.ToString());

                }

            }

        }
    }
}
