using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HRMSLib
{
    public sealed class Date
    {
        #region Private Data Members
        private int _day; private int _month; private int _year;
        #endregion

        #region Constructors
        public Date()
        {
            this.Day = 2;
            this.Month = 1;
            this.Year = 1990;
        }
        public Date(int day, int month, int year)
        {
            this.Year = year;
            this.Month = month;
            this.Day = day;


        }

        #endregion

        #region Properties

        
        public int Day
        {
            get { return _day; }
            set
            {
                if (value < 1)
                {
                    _day = 1;
                }
                else if (this.Month == 2 && this.Year % 4 == 0 && value > 29)
                {
                    _day = 29;
                }
                else if (this.Month == 2 && this.Year % 4 != 0 && value > 28)
                {
                    _day = 28;
                }
                else if ((this.Month == 4 || this.Month == 6 || this.Month == 9 || this.Month == 11) && value > 30)
                {
                    _day = 30;
                }
                else if ((this.Month == 1 || this.Month == 3 || this.Month == 5 || this.Month == 7 || this.Month == 8 || this.Month == 10 || this.Month == 12) && value > 31)
                {
                    _day = 31;
                }
                else
                {
                    _day = value;
                }
            }
        }

        

        public int Month
        {
            get { return _month; }
            set
            {
                if (value >= 1 && value <= 12)
                    _month = value;
                else
                    _month = 1;
            }
        }

        

        public int Year
        {
            get { return _year; }
            set
            {
                if (value >= 1901 && value <= 2100)
                    _year = value;
                else
                    _year = 1901;
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format("{0}/{1}/{2}", this.Day, this.Month, this.Year);
        }

        public static int DateDiff(Date date1, Date date2)
        {
            return date1.Year - date2.Year;
        }
        public static int operator -(Date date1, Date date2)
        {
            return date1.Year - date2.Year;
        }
       
        #endregion
    }
}
