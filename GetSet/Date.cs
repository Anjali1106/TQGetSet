using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    internal class Date
    {
        // declare data members
        private int day, year;

        private string month;
        // method for assign the value to the data member

        // properties for each data member
        // Day is a property name

        public int Day {
            get { return day; } // retrieve the value
            set { day = value; }  // assign the value

        }

        public string Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        // return the date to main method
        public string DisplayDate()
        {
            return $"Date is : {day} / {month} /{year}";
        }


    }
}
