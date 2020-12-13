using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Student
    {
        private string fName, lName;
        private int sID;

        public Student(string _fname, string _lname, int _sid)
        {
            this.fName = _fname;
            this.lName = _lname;
            this.sID = _sid;
        }

        public override string ToString()
        {
            return $"{FName}      \t{LName}\t\t{SID}";
        }

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }

        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }

        public int SID
        {
            get { return sID; }
            set { sID = value; }
        }
    }
}
