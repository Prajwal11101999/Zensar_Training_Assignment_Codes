using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_Plan_1
{
    class App
    {
        static void Main(string[] args)
        {
            /*
            int size;
            Console.WriteLine("Enter the Number of Elements to be Entered in Course Class : ");
            size = int.Parse(Console.ReadLine());
            Course[] courses = new Course[size];
            AppEngine.introduce(courses);
            int size1;
            Console.WriteLine("Enter the Number of Elements to be Entered in Student Class : ");
            size1 = int.Parse(Console.ReadLine());
            Student[] students = new Student[size1];
            AppEngine.register(students);
            AppEngine.ListOfStudents(students);
            AppEngine.ListOfCourses(courses);
            List<Enroll> enroll_infos = new List<Enroll>();
            AppEngine.enroll(students, courses, enroll_infos);
            AppEngine.ListOfEnrolment(enroll_infos);
            */
            List<Course> courses = new List<Course>();
            AppEngine.introduce(courses);
            List<Student> students = new List<Student>();
            AppEngine.register(students);
            AppEngine.ListOfStudents(students);
            AppEngine.ListOfCourses(courses);
            List<Enroll> enroll_infos = new List<Enroll>();
            AppEngine.enroll(students, courses, enroll_infos);
            AppEngine.ListOfEnrolment(enroll_infos);
        }
    }
}
