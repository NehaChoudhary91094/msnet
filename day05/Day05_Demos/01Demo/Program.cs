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
            #region Below is the way to write Getter Setter in .C#

            //Person person = new Person();
            //person.Age = 40;
            //person.Name = "MP";
            //string details = person.GetDetails();
            //Console.WriteLine(details);

            Employee emp = new Employee();
            emp.Name = "mahesh";
            emp.Age = 40;
            emp.DName = "IT";

            string details = emp.GetDetails();
            Console.WriteLine(details);

            #endregion
        }
    }

    public class Person
    {
        #region Private Members
        private string _Name;
        private int _Age;
        #endregion

        #region Constructors
        public Person()
        {
            this.Name = "";
            this.Age = 0;
        }

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
        #endregion

        #region Getter Setters
        
        public string Name
        {
            get 
            {
                return "Mr / Mrs " + this._Name;
            }
            set 
            {
                if (value!="")
                {
                    this._Name = value;
                }
                else
                {
                    this._Name = "No Data";
                }
            }
        }

        public int Age
        {
            get 
            {
                return this._Age;
            }
            set
            {
                this._Age = value;
            }
        }


        #endregion

        #region Member Functions
        public virtual string GetDetails()
        {
            return "Welcome " + this.Name + " with Age " + this.Age.ToString();
        }
        #endregion
    }


    public class Employee: Person
    {

        private string _DName;

        public string DName
        {
            get { return _DName; }
            set { _DName = value; }
        }

        public override string GetDetails()
        {
            return base.GetDetails() + " from department " + this.DName;
        }
    }
}
