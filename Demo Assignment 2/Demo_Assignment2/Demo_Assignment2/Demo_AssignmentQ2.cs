using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Assignment2
{

    class Student
    {
        public int Stud_RollNo;
        public string Stud_Name;
        public string Stud_Class;
        public int Stud_SEM;
        public string Stud_Branch;
        public int[] S_Marks = new int[5];

        public Student(int rollno, string sname, string sclass, int ssem, string sbranch)
        {
            Stud_RollNo = rollno;
            Stud_Name = sname;
            Stud_Class = sclass;
            Stud_SEM = ssem;
            Stud_Branch = sbranch;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"The Roll Number of Student is : {Stud_RollNo} ");
            Console.WriteLine($"The Name of Student is : {Stud_Name} ");
            Console.WriteLine($"The Class of Student is : {Stud_Class} ");
            Console.WriteLine($"The Semester in which Student is in : {Stud_SEM} ");
            Console.WriteLine($"The Branch in which Student Studies is : {Stud_Branch} ");
        }

        public int Accept_Marks()
        {
            Console.WriteLine("Enter the Marks for 5 Subjects : ");
            for (int i = 0; i < 5; i++)
            {
                S_Marks[i] = int.Parse(Console.ReadLine());
            }
            return 0;
        }

        public void Stud_Results()
        {
            int total = 0;
            // float average;
            for (int i = 0; i < 5; i++)
            {
                total = total + S_Marks[i];
            }

            float average = (float)total / S_Marks.Length;

            Console.WriteLine("The Average of all Marks is : {0} ",average);

            if ((S_Marks[0] < 35) || (S_Marks[1] < 35) || (S_Marks[2] < 35) || (S_Marks[3] < 35) || (S_Marks[4] < 35))
            {
                Console.WriteLine("Failed because there is one subject with less marks than 35.");
            }
            else if (((S_Marks[0] >= 35) && (S_Marks[1] >= 35) && (S_Marks[2] >= 35) && (S_Marks[3] >= 35) && (S_Marks[4] >= 35)) && (average < 50))
            {
                Console.WriteLine("Failed because the average is less than 50.");
            }
            else
            {
                Console.WriteLine("Passed Because average is more than 50.");
            }
        }

    }

    class Demo_AssignmentQ2
    {
        static void Main(string[] args)
        {
            Student stud = new Student(65852, "Prajwak Borawake", "G2", 1, "Computer Engineering");
            stud.DisplayDetails();
            stud.Accept_Marks();
            stud.Stud_Results();
        }
    }
}
