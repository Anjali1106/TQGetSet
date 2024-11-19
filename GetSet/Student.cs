using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    internal class Student
    {
        private int sid;
        private string sname;
        private int sage;

        public int SID { 
            get { return sid; } 
            set { sid = value; } 
        }

        public String SName {

            get { return sname; }
            set { sname = value; }
        }

        public int SAge
        {
            get { return sage; }
            set { sage = value; }
        }

        public string display()
        {
            return $"SID: {sid}";
        }
    }
}
