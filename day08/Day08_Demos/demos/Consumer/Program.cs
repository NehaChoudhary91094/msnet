using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
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

            foreach (Type type in allTypes)
            {
                Console.WriteLine("Type: " + type.Name);

                MethodInfo[] allMethods = type.GetMethods();

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
                }

            }

        }
    }
}
