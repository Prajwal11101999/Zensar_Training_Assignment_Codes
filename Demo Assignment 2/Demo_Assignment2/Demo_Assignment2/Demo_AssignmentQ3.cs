using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Assignment2
{

    abstract class Student1
    {
        abstract public bool Ispassed(float grade1);
        public string Stud_Name;
        public int Stud_Id;
        public float Stud_Grade;

        public void GetData()
        {
            Console.WriteLine("Enter the Student Name : ");
            Stud_Name = Console.ReadLine();
            Console.WriteLine("Enter the Student ID : ");
            Stud_Id = int.Parse(Console.ReadLine());
        }

        public void DisplayData()
        {
            Console.WriteLine("The Name of the Student is : {0}", Stud_Name);
            Console.WriteLine("The Student Id is : {0}", Stud_Id);
        }
    }

    class Undergraduate : Student1
    {
        /*
        public float Stud_Grade1;

        public void GetGrade()
        {
            Console.WriteLine("Enter the Grade got in Undergraduate Class : ");
            Stud_Grade1 = float.Parse(Console.ReadLine());
        }
        */
        public override bool Ispassed(float grade1)
        {
            if(grade1 >= 70.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Graduate : Student1
    {
        /*
        public float Stud_Grade2;

        public void GetGrade()
        {
            Console.WriteLine("Enter the Grade got in Graduate Class : ");
            Stud_Grade2 = float.Parse(Console.ReadLine());
        }
        */
        public override bool Ispassed(float grade1)
        {
            if (grade1 >= 80.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Demo_AssignmentQ3
    {
        static void Main(string[] args)
        {
            bool Pass;
            Undergraduate UG = new Undergraduate();
            UG.GetData();
            UG.DisplayData();
            // UG.GetGrade();
            Pass = UG.Ispassed(50.0f);
            if(Pass)
            {
                Console.WriteLine("The Student Passed in Undergraduation.");
            }
            else
            {
                Console.WriteLine("The Student Failed in Undergraduation");
            }
            Graduate G = new Graduate();
            G.GetData();
            G.DisplayData();
            // G.GetGrade();
            Pass = G.Ispassed(30.0f);
            if (Pass)
            {
                Console.WriteLine("The Student Passed in Graduation.");
            }
            else
            {
                Console.WriteLine("The Student Failed in Graduation");
            }
        }
    }
}
