using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSLib
{
    
    public class WageEmp : Employee
    {
        public new double HRA
        {
            get
            {

                return 0;
            }

        }

        public new double DA
        {
            get
            {

                return 0;
            }
        }
        private new double Salary
        {
            get { return 0; }
            set { this.Salary = 0; }
        }
        public WageEmp() : base()
        {
            this.Designation = "Labour";
            this.Hours = 8;
            this.Rate = 500;
        }
        public WageEmp(double hours, double rate, string passcode, int deptNo, Date hireDate, EmployeeTypes employeeType, string name, bool gender, string address, Date birthDate, string emailId)
            : base(passcode,deptNo, hireDate, 0, "Labour", employeeType, name, gender, address, birthDate, emailId)
        {
            this.Hours = hours;
            this.Rate = rate;
        }

        double _hours;
        public double Hours
        {
            get { return _hours; }
            set { _hours = value; }
        }

        private double _rate;

        public double Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }


        public sealed override double NetSalary
        {
            get
            {
                return Hours * Rate;
            }
        }
        public override string ToString()
        {
            return base.ToString() + "\r\n" +
                    "Hours=" + this.Hours + "\r\n" +
                    "Rate=" + this.Rate + "\r\n";
        }
    }
}
