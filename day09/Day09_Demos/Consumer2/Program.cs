using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Consumer2
{
    class Program
    {
        static void Main(string[] args)
    {

        Console.WriteLine("Enter the Assembly Path : EXE / DLL built with .NET");
        string pathOfAssembly = Console.ReadLine();

        // @"E:\PuneDAC\Day09\demos\MathsLib\bin\Debug\MathsLib.dll";

        //below code is for loading top level TYPE metadata information from MathsLib.dll
        Assembly assembly = Assembly.LoadFrom(pathOfAssembly);

        //Now we ask assembly object rest of the details....

        Type[] allTypes = assembly.GetTypes();

        object dynamicObject = null;
    

        foreach (Type type in allTypes)
        {
            Console.WriteLine("Type: " + type.Name);

            List<Attribute> allAttributes = type.GetCustomAttributes().ToList();
                bool isItSerializable = false;
                foreach (Attribute attribute in allAttributes)
                {
                    if (attribute is SerializableAttribute)
                    {
                        isItSerializable = true;
                        break;
                    }
                }

                if (isItSerializable)
                {
                    Console.WriteLine(type.Name + " is serializable");
                }
                else
                {
                    Console.WriteLine(type.Name + " is not marked as serializable");
                }

            dynamicObject = assembly.CreateInstance(type.FullName);


            MethodInfo[] allMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            foreach (MethodInfo method in allMethods)
            {
                    Console.WriteLine("Calling " + method.Name + " method ....");
                ParameterInfo[] allParams = method.GetParameters();

                object[] arguments = new object[allParams.Length];

                    for (int i =0; i<allParams.Length; i++)
                    {
                        Console.WriteLine("Enter " + allParams[i].ParameterType.ToString() + "value for " + allParams[i].Name );

                        arguments[i] = Convert.ChangeType(Console.ReadLine(),
                                                            allParams[i].ParameterType);
                        
                    }

                object result = type.InvokeMember(method.Name,
                                    BindingFlags.Public |
                                    BindingFlags.Instance |
                                    BindingFlags.InvokeMethod,
                                    null, dynamicObject, arguments);

                Console.WriteLine("Result of " + method.Name + " executed is " + result.ToString());

            }

        }

    }
    }
}
