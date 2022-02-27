using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_Plan_1
{
    class AppEngine
    {

        public static void introduce(List<Course> course)
        {
            for (int i = 0; i < course.Count; i++)
            {
                int id;
                float duration, fee;
                string name;
                Console.WriteLine("Enter Course ID : ");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Course Name : ");
                name = Console.ReadLine();
                Console.WriteLine("Enter Course Duration : ");
                duration = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Course Fees : ");
                fee = float.Parse(Console.ReadLine());
                course.Add(new Course(id, name, duration, fee));
            }
        }
        
        public static void register(List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                int id, y, m, d;
                string name;
                Console.WriteLine("Enter Student ID : ");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Student Name : ");
                name = Console.ReadLine();
                Console.WriteLine("Enter Student Birth Year : ");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Student Birth Month : ");
                m = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Student Birth Day : ");
                d = int.Parse(Console.ReadLine());
                students.Add(new Student(id, name, y, m, d));
            }
        }

        public static List<Student> ListOfStudents(List<Student> students)
        {
            Info info = new Info();
            for (int i = 0; i < students.Count; i++)
            {
                info.Display(students[i]);
                Console.WriteLine("***********************************************************************************");
            }
            return students;
        }

        public static Course[] ListOfCourses(Course[] course)
        {
            Info info = new Info();
            for (int i = 0; i < course.Length; i++)
            {
                info.Display1(course[i]);
                Console.WriteLine("***********************************************************************************");
            }
            return course;
        }

        public static void enroll(Student[] stud, Course[] cour, List<Enroll> enrolls)
        { 
            for (int i = 0; i < stud.Length; i++)
            {
                /*
                enroll_info[i].stud_info = stud[i];
                enroll_info[i].course_info = cour[i];
                */
                DateTime edate;
                Console.WriteLine("Enter the Enrollment Date of the Course : ");
                edate = Convert.ToDateTime(Console.ReadLine());
                enrolls.Add(new Enroll(stud[i], cour[i], edate));
            }
        }

        public static List<Enroll> ListOfEnrolment(List<Enroll> enroll_info)
        {
            Info info = new Info();
            info.Display2(enroll_info);
            return enroll_info;
        }   
    }
}
