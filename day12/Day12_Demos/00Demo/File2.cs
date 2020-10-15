using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00Demo
{
    //Developer No 2
    public partial class Emp
    {
        partial void Validate(string propertyName, object Value)
        {
            if (propertyName == "Age")
            {
                int age = Convert.ToInt32(Value);
                if (age < 18  || age > 60)
                {
                    Console.WriteLine("Age is set up wrong!");
                }

            }
        }

        public string GetDetails()
        {
            return "Some EMP Details..";
        }
    }
}
