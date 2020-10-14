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
            List<Emp> emps = new List<Emp>() 
            {
                new Emp{ No = 11, Name = "Mahesh"  , Address="pune" },
                new Emp{ No = 12, Name = "Rahul"  , Address="panji" },
                new Emp{ No = 13, Name = "Rajiv"  , Address="mumbai" },
                new Emp{ No = 14, Name = "Ketan"  , Address="manglore" },
                new Emp{ No = 15, Name = "Yogesh"  , Address="banglore" },
                new Emp{ No = 16, Name = "Amit"  , Address="chennai" },
                new Emp{ No = 17, Name = "Nilesh"  , Address="pune" },
                new Emp{ No = 18, Name = "Nitin"  , Address="satara" },
                new Emp{ No = 19, Name = "Vishal"  , Address="kolhapur" },
                new Emp{ No = 20, Name = "Sachin"  , Address="chennai" }
            };

            Console.WriteLine(  "Enter City Search Character");
            string cityFilter = Console.ReadLine();

            //var result = new List<Emp>();

            //foreach (Emp emp in emps)
            //{
            //    if (emp.Address.Contains(cityFilter))
            //    {
            //        result.Add(emp);
            //    }
            //}

            ////var result = (from emp in emps
            ////              where emp.Address.StartsWith(cityFilter)
            ////              select emp).ToList();

            ////emps.Add(new Emp() { No = 11, Name = "Ashutosh", Address = "manmad" });

            ////Console.WriteLine("Filtered Result is ---");
            ////foreach (Emp e in result)
            ////{
            ////    Console.WriteLine(e.Name + " is from " + e.Address);
            ////}
            ////---------------------------------------------------------


            var result = (from emp in emps
                          where emp.Address.StartsWith(cityFilter)
                          select new 
                          {
                              EName = "Mr / Mrs " + emp.Name,
                              ECity = emp.Address
                          }).ToList();

            
            //var result =  emps.where().select();
            
            Console.WriteLine("Filtered Result is ---");
            foreach (var e in result)
            {
                Console.WriteLine(e.EName + " is from " + e.ECity);
            }
        }
    }

    public class ResultHolder
    {
        public string EName { get; set; }
        public string ECity { get; set; }
    }

    public class Emp
    {
        public int No { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
