using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Using Person Colletion To Hold Data of Emp & Customer
            //    Emp e1 = new Emp();
            //    e1.No = 1;
            //    e1.Name = "Rajiv";
            //    e1.DName = "IT";

            //    Emp e2 = new Emp();
            //    e2.No = 2;
            //    e2.Name = "Rahul";
            //    e2.DName = "Admin";


            //    Emp e3 = new Emp();
            //    e3.No = 3;
            //    e3.Name = "Mahesh";
            //    e3.DName = "IT";

            //    Customer c1 = new Customer();
            //    c1.No = 4;
            //    c1.Name = "Dev";
            //    c1.OrderDetails = "Laptop";

            //    Customer c2 = new Customer();
            //    c2.No =5;
            //    c2.Name = "Amol";
            //    c2.OrderDetails = "Mobile";


            //    Person[] people = new Person[5];
            //    people[0] = e1;
            //    people[1] = e2;
            //    people[2] = e3;
            //    //people[3] = c1;
            //    //people[4] = c2;

            //    for (int i = 0; i < people.Length; i++)
            //    {
            //        if (people[i]!=null)
            //        {
            //            Console.WriteLine(people[i].getDetails());
            //        }
            //    }
            //} 
            #endregion

            #region Using Objecct Collection to Hold Data of Emp & Customer
            Emp e1 = new Emp();
            e1.No = 1;
            e1.Name = "Rajiv";
            e1.DName = "IT";

            Emp e2 = new Emp();
            e2.No = 2;
            e2.Name = "Rahul";
            e2.DName = "Admin";


            Emp e3 = new Emp();
            e3.No = 3;
            e3.Name = "Mahesh";
            e3.DName = "IT";

            Customer c1 = new Customer();
            c1.No = 4;
            c1.Name = "Dev";
            c1.OrderDetails = "Laptop";

            Customer c2 = new Customer();
            c2.No = 5;
            c2.Name = "Amol";
            c2.OrderDetails = "Mobile";


            object[] people = new object[5];
            people[0] = e1;
            people[1] = e2;
            people[2] = e3;
            people[3] = c1;
            people[4] = c2;

            for (int i = 0; i < people.Length; i++)
            {
                if (people[i] != null)
                {
                    if (people[i] is Emp)
                    {
                        // Emp e = (Emp)people[i];
                        // Console.WriteLine(e.getDetails());
                        Console.WriteLine(((Emp)people[i]).getDetails());
                    }
                    else if (people[i] is Customer)
                    {
                        Customer c = (Customer)people[i];
                        Console.WriteLine(c.getDetails());
                    }
                }
            }
            #endregion
        }
    }

    public class Person
    {
        //public Person(int no, string name)
        //{
        //    this.No = no;
        //    this.Name = name;
        //}
        private int _No;
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int No
        {
            get { return _No; }
            set { _No = value; }
        }


        public virtual string getDetails()
        {
            return No.ToString() + Name;
        }
    }

    public class Emp: Person
    {
        //public Emp(int no, string name , string dname): base(no, name)
        //{
        //    this.DName = dname;
        //}
        private string _DName;

        public string DName
        {
            get { return _DName; }
            set { _DName = value; }
        }

        public override string getDetails()
        {
            return base.getDetails() + this.DName;
        }
    }

    public class Customer : Person
    {
        private string _OrderDetails;

        public string OrderDetails
        {
            get { return _OrderDetails; }
            set { _OrderDetails = value; }
        }


        public override string getDetails()
        {
            return base.getDetails() + this.OrderDetails;
        }
    }
}
