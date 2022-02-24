using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_Plan_1
{
    class Student
    {
        private int Stud_ID;
        public int Student_Id
        {
            get
            {
                return Stud_ID;
            }
            set
            {
                Stud_ID = value;
            }
        }

        private string Stud_Name;
        public string Student_Name
        {
            get
            {
                return Stud_Name;
            }
            set
            {
                Stud_Name = value;
            }
        }


        private int mYears;
        private int mMonths;
        private int mDays;

        public int AgeYears
        {
            get
            {
                return mYears;
            }
            set
            {
                mYears = value;
            }
        }
        public int AgeMonths
        {
            get
            {
                return mMonths;
            }
            set
            {
                mMonths = value;
            }
        }
        public int AgeDays
        {
            get
            {
                return mDays;
            }
            set
            {
                mDays = value;
            }
        }

        public Student(int a, string b, int year, int month, int day)
        {
            Student_Id = a;
            Student_Name = b;
            AgeYears = year;
            AgeMonths = month;
            AgeDays = day;
        }
    }
}
