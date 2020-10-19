using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSLib
{
    public  abstract class Person
    {
        #region Private data member
        private string _name;
        private bool _gender;
        private string _address;
        private Date _birthdate;
        private int _age;
        private string _emailId;    

        #endregion

        #region Constructors
        public Person()
        {
            this.Name = "Rahul";
            this.Gender = true;
            this.Address = "Karad";
            this.BirthDate = new Date();
            this.EmailId = "rahuls@sunbeaminfo.com";
        }

        public Person(string name, bool gender, string address, Date birthDate, string emailId)
        {
            this.Name = name;
            this.Gender = gender;
            this.Address = address;
            this.BirthDate = birthDate;
            this.EmailId = emailId;
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public Date BirthDate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }
        public string EmailId
        {
            get { return _emailId; }
            set { _emailId = value; }
        }
        public int Age
        {
            get
            {
                Date currentDate = new Date(8, 10, 2020);
                //_age = Date.DateDiff(currentDate, this.BirthDate);
                _age = currentDate - this.BirthDate;
                return _age;
            }
        }
        #endregion

        #region Methods              
        public override string ToString()
        {
            return  "Name=" + this.Name + "\r\n" +
                    "Gender=" + this.Gender + "\r\n" +
                    "Address=" + this.Address + "\r\n" +
                    "BirthDate=" + this.BirthDate.ToString() +"\r\n" +
                    "Age=" + this.Age.ToString() + "\r\n";
        }
        #endregion

    }
}
