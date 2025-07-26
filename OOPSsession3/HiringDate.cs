using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSsession3
{
    internal class HiringDate
    {
        // Fields
        private int _day;
        private int _month;
        private int _year;

       
        public int Day
        {
            get { return _day; }
            set
            {
                if (value < 1 || value > 31)
                    throw new ArgumentOutOfRangeException("Day must be between 1-31");
                _day = value;
            }
        }

        public int Month
        {
            get { return _month; }
            set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentOutOfRangeException("Month must be between 1-12");
                _month = value;
            }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                    throw new ArgumentOutOfRangeException($"Year must be between 1900-{DateTime.Now.Year}");
                _year = value;
            }
        }

        // Constructors
        public HiringDate(int day, int month, int year)
        {
            Year = year;  
            Month = month;
            Day = day;

     
        }

        // Override ToString()
        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }

     
    
}
}
