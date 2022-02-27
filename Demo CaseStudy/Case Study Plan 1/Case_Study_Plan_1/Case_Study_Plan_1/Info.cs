using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_Plan_1
{
    class Info
    {
        public void Display(List<Student> student)
        {
            var display = from disp in student
                          select disp;
            foreach (var item in display)
            {
                Console.WriteLine("Student ID = {0}", item.Student_Id);
                Console.WriteLine("Student Name = {0}", item.Student_Name);
                Console.WriteLine("Student Date of Birth = {0}/{1}/{2}", item.AgeDays, item.AgeMonths, item.AgeYears);
            }
        }

        public void Display1(Course course)
        {
            // Console.WriteLine("Student Selected Course Info : ");
            Console.WriteLine("Course ID : {0}", course.Course_Id);
            Console.WriteLine("Course Name : {0}", course.Course_name);
            Console.WriteLine("Course Duration : {0} Months.", course.Course_Duration);
            Console.WriteLine("Course Fees : {0} Rupees.", course.Course_Fees);
        }
        /*
        public void Display2(Enroll enroll)
        {
            Display(enroll.stud_info);
            Display1(enroll.course_info);
            Console.WriteLine("Enrollment Date : {0} ", enroll.enrollDate);
        }
        */

        public void Display2(List<Enroll> enrolls)
        {
            var display = from disp in enrolls
                          select disp;
            foreach (var item in display)
            {
                Display(item.stud_info);
                Display1(item.course_info);
                Console.WriteLine("Enrollment Date : {0} ",item.enrollDate);
            }
        }

    }
}
