using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using MyOwnAttributes;
namespace DbGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path of your class library:");
            string path = Console.ReadLine();

            Assembly assembly = Assembly.LoadFrom(path);

            Type[] allTypes = assembly.GetTypes();
            string query = "";

            foreach (Type type in allTypes)
            {
                List<Attribute> allAttributes = type.GetCustomAttributes().ToList();

                foreach (Attribute attribute in allAttributes)
                {
                    if (attribute is Table)
                    {
                        Table tableAttributeObject = (Table)attribute;
                        string tableName = tableAttributeObject.TableName;
                        query = query + " create table " + tableName + " ( ";
                        break;
                    }
                }

                PropertyInfo[] allGettersSetters = type.GetProperties();

                foreach (PropertyInfo propertyInfo in allGettersSetters)
                {
                    List<Attribute> allAttributesOnCurrentGetterSetter = propertyInfo.GetCustomAttributes().ToList();

                    foreach (Attribute attributeOnGetterSettter in allAttributesOnCurrentGetterSetter)
                    {
                        if(attributeOnGetterSettter is Column)
                        {
                            Column columnAttributeObject = (Column)attributeOnGetterSettter;
                            query = query + columnAttributeObject.ColumnName + "  " +   columnAttributeObject.ColumnType + ",";
                            break;
                        }
                    }
                }

                query =  query.TrimEnd(new char[] { ',' });
                query = query + " ); ";
            }
            Console.WriteLine(query);

        }
    }
}
