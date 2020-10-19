using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSLib
{
    public class Salesperson : Employee
    {
        double _commision;
        public Salesperson() : base()
        {
            this.Designation = "Salesperson";
            this.Commision = 500;
        }
        public Salesperson(double commision, string passcode, int deptNo, Date hireDate,double salary, EmployeeTypes employeeType, string name, bool gender, string address, Date birthDate, string emailId)
            : base(passcode, deptNo, hireDate, salary, "Salesperson", employeeType, name,gender, address, birthDate, emailId)
        {            
            this.Commision = commision;
        }

        public double Commision
        {
            get { return _commision; }
            set { _commision = value; }
        }
        public override double NetSalary
        {
            get
            {
                return base.NetSalary + this.Commision;
            }
        }
        public override string ToString()
        {
           return base.ToString() + "\r\n" +
                 "Commision=" + this.Commision+ "\r\n";
        }
    }
}