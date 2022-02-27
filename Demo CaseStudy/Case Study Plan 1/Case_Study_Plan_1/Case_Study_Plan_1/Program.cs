using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_Plan_1
{
    class Program
    {
        /*
        public static void Scenario1Student()
        {
            Student s1 = new Student(1001, "Prajwal", 1999, 10, 11);
            Student s2 = new Student(1002, "Priti", 1978, 11, 21);
            Student s3 = new Student(1003, "Shreya", 2004, 12, 30);
            Student s4 = new Student(1004, "ninad", 1970, 01, 23);

            Info i1 = new Info();
            i1.Display(s1);
            Console.WriteLine("***********************************************************************************");
            i1.Display(s2);
            Console.WriteLine("***********************************************************************************");
            i1.Display(s3);
            Console.WriteLine("***********************************************************************************");
            i1.Display(s4);
            Console.WriteLine("***********************************************************************************");
        }
        */
        public static void Scenario2Student()
        {
            Student[] students =
            {
                new Student(1001, "Ninad", 1999, 05, 21),
                new Student(1002, "Hemant", 1990, 01, 2),
                new Student(1003, "Shrushti", 2001, 04, 29),
                new Student(1004, "Prakrut", 1960, 10, 01)
            };

            Info i2 = new Info();
            
            i2.Display(students[0]);
            Console.WriteLine("***********************************************************************************");
            i2.Display(students[1]);
            Console.WriteLine("***********************************************************************************");
            i2.Display(students[2]);
            Console.WriteLine("***********************************************************************************");
            i2.Display(students[3]);
            Console.WriteLine("***********************************************************************************");
            
            // OR
            /*
            for (int i = 0; i < students.Length; i++)
            {
                i2.Display(students[i]);
                Console.WriteLine("***********************************************************************************");
            }
            */
        }
        /*
        public static void Scenario3Student()
        {
            Student[] students = new Student[4];
            for (int i = 0; i < students.Length; i++)
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
                students[i] = new Student(id, name, y, m, d);
            }
            Info i3 = new Info();
            for (int i = 0; i < students.Length; i++)
            {
                i3.Display(students[i]);
                Console.WriteLine("***********************************************************************************");
            }
        }
        */
        /*
        public static void Scenario1Course()
        {
            Course c1 = new Course(01, "Java FullStack", 06, 20000);
            Course c2 = new Course(02, "Dot NET", 03, 25000);
            Course c3 = new Course(03, "Python", 03, 15000);
            Course c4 = new Course(04, "AI & ML", 09, 30000);
            Info i1 = new Info();
            i1.Display1(c1);
            Console.WriteLine("***********************************************************************************");
            i1.Display1(c2);
            Console.WriteLine("***********************************************************************************");
            i1.Display1(c3);
            Console.WriteLine("***********************************************************************************");
            i1.Display1(c4);
            Console.WriteLine("***********************************************************************************");
        }
        */
        public static void Scenario2Course()
        {
            Course[] course =
            {
                new Course(01, "Java FullStack", 06, 20000),
                new Course(02, "Dot NET", 03, 25000),
                new Course(03, "Python", 03, 15000),
                new Course(04, "AI & ML", 09, 30000)
            };

            /*
            Info i2 = new Info();
            i2.Display1(course[0]);
            Console.WriteLine("***********************************************************************************");
            i2.Display1(course[1]);
            Console.WriteLine("***********************************************************************************");
            i2.Display1(course[2]);
            Console.WriteLine("***********************************************************************************");
            i2.Display1(course[3]);
            Console.WriteLine("***********************************************************************************");
            */
        }
        /*
        public static void Scenario3Course()
        {
            Course[] course = new Course[4];
            for (int i = 0; i < course.Length; i++)
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
                course[i] = new Course(id, name, duration, fee);
            }
            Info i3 = new Info();
            for (int i = 0; i < course.Length; i++)
            {
                i3.Display1(course[i]);
                Console.WriteLine("***********************************************************************************");
            }
        }
        */
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("\t\t\t\t SCENARIO OF STUDENT ClASS STARTS ");
            Console.WriteLine("\t\t\t\t START OF SCENARIO : 1 !!!!!!!!!!!!!!!!");
            Scenario1Student();
            Console.WriteLine("\t\t\t\t END OF SCENARIO : 1 !!!!!!!!!!!!!!!!");
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine("\t\t\t\t START OF SCENARIO : 2 !!!!!!!!!!!!!!!!");
            Scenario2Student();
            Console.WriteLine("\t\t\t\t END OF SCENARIO : 2 !!!!!!!!!!!!!!!!");
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine("\t\t\t\t START OF SCENARIO : 3 !!!!!!!!!!!!!!!!");
            Scenario3Student();
            Console.WriteLine("\t\t\t\t END OF SCENARIO : 3 !!!!!!!!!!!!!!!!");
            */

            Console.WriteLine("\t\t\t\t START OF SCENARIO : 2 !!!!!!!!!!!!!!!!");
            Scenario2Student();
            Console.WriteLine("\t\t\t\t END OF SCENARIO : 2 !!!!!!!!!!!!!!!!");


            Console.WriteLine();
            Console.WriteLine("\t\t\t\t SCENARIO OF COURSE ClASS STARTS ");
            Console.WriteLine();


            Console.WriteLine("\t\t\t\t START OF SCENARIO : 2 !!!!!!!!!!!!!!!!");
            Scenario2Course();
            Console.WriteLine("\t\t\t\t END OF SCENARIO : 2 !!!!!!!!!!!!!!!!");


            /*
            Console.WriteLine("\t\t\t\t START OF SCENARIO : 1 !!!!!!!!!!!!!!!!");
            Scenario1Course();
            Console.WriteLine("\t\t\t\t END OF SCENARIO : 1 !!!!!!!!!!!!!!!!");
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine("\t\t\t\t START OF SCENARIO : 2 !!!!!!!!!!!!!!!!");
            Scenario2Course();
            Console.WriteLine("\t\t\t\t END OF SCENARIO : 2 !!!!!!!!!!!!!!!!");
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine("\t\t\t\t START OF SCENARIO : 3 !!!!!!!!!!!!!!!!");
            Scenario3Course();
            Console.WriteLine("\t\t\t\t END OF SCENARIO : 3 !!!!!!!!!!!!!!!!");
            */
        }
    }
}
