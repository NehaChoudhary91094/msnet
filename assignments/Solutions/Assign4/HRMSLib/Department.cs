using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSLib
{
    public class Department
    {
        #region Private Data member
        private int _deptNo;
        private string _deptName;
        private string _location;

        #endregion

        #region Constructors
        public Department()
        {
            this.DeptNo = 420;
            this.DeptName = "Timepass";
            this.Location = "Pune";
        }

        public Department(int deptno, string deptName, string location)
        {
            this.DeptNo = deptno;
            this.DeptName = deptName;
            this.Location = location;

        }
        #endregion

        #region Properties
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public string DeptName
        {
            get { return _deptName; }
            set { _deptName = value; }
        }

        public int DeptNo
        {
            get { return _deptNo; }
            set { _deptNo = value; }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return "DeptNo=" + this.DeptNo + "\r\n" +
                    "DeptName=" + this.DeptName + "\r\n" +
                    "Location=" + this.Location + "\r\n";
        }
        #endregion

    }
}
