using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HRMSLib
{
    public class Employee : Person
    {

        #region Private data members
        static int counter = 0;
        private int _id;
        private string _designation;
        private EmployeeTypes _employeeType;
        private double _salary;
        private double _hra;
        private double _da;
        private double _netsalary;

        private int _deptNo;
        private string _passcode;
        private Date _hireDate;
        #endregion

        #region Constructors
        public Employee() : base()
        {
            counter++;
            this.Salary = 50000;
            this.Designation = "Associate Head";
            this.EmployeeType = EmployeeTypes.Permanent;
            this.HireDate = new Date(10, 10, 2001);
            this.DeptNo = 10;
            this.Passcode = "abc@123";
        }

        public Employee(string passcode, int deptNo, Date hireDate, double salary, string designation, EmployeeTypes employeeType, string name, bool gender, string address, Date birthDate, string emailId) : base(name, gender, address, birthDate, emailId)
        {
            counter++;
            this.Salary = salary;
            this.Designation = designation;
            this.EmployeeType = employeeType;
            this.Passcode = passcode;
            this.DeptNo = deptNo;
            this.HireDate = hireDate;
        }
        #endregion

        #region Properties
               
        public Date HireDate
        {
            get { return _hireDate; }
            set { _hireDate = value; }
        }

        public string Passcode
        {
            get { return _passcode; }
            set { _passcode = value; }
        }

        public int DeptNo
        {
            get { return _deptNo; }
            set { _deptNo = value; }
        }      

        public int Id
        {
            get {
                _id = counter;
                return _id; 
            }
        }

        public string Designation
        {
            get { return _designation; }
            set { _designation = value; }
        }

        public EmployeeTypes EmployeeType
        {
            get { return _employeeType; }
            set { _employeeType = value; }
        }

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public double HRA
        {
            get 
            {
                _hra = this.Salary * 0.40;
                return _hra; 
            }
            
        }

        public double DA
        {
            get
            {
                _da = this.Salary * 0.10;
                return _da;
            }

        }

        public virtual double NetSalary
        {
            get
            {
                _netsalary = this.Salary + this.HRA + this.DA;
                return _netsalary;
            }

        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return base.ToString() +
                    "Employee Code=" + this.Id + "\r\n" +
                    "Passcode=" + this.Passcode + "\r\n" +
                    "DeptNo=" + this.DeptNo + "\r\n" +
                    "Hire Date=" + this.HireDate.ToString() + "\r\n" +
                    "Designation=" + this.Designation + "\r\n" +
                    "EmployeeType=" + this.EmployeeType + "\r\n" +
                    ((this is WageEmp) ? "\r\n" : "Salary=" + this.Salary + "\r\n" + "HRA=" + this.HRA + "\r\n" + "DA=" + this.DA + "\r\n") +
                    "NetSalary=" + this.NetSalary+ "\r\n";
        }
        #endregion

    }
}
