using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_Plan_1
{
    class Info
    {
        public void Display(Student student)
        {
            Console.WriteLine("Student ID = {0}", student.Student_Id);
            Console.WriteLine("Student Name = {0}", student.Student_Name);
            Console.WriteLine("Student Date of Birth = {0}/{1}/{2}", student.AgeDays, student.AgeMonths, student.AgeYears);
        }

        public void Display1(Course course)
        {
            // Console.WriteLine("Student Selected Course Info : ");
            Console.WriteLine("Course ID : {0}", course.Course_Id);
            Console.WriteLine("Course Name : {0}", course.Course_name);
            Console.WriteLine("Course Duration : {0} Months.", course.Course_Duration);
            Console.WriteLine("Course Fees : {0} Rupees.", course.Course_Fees);
        }
    }
}
