using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Assignment_1
{
    class Assignment_Q4
    {
        public int CSharp;
        public int HTML;
        public int Sql;

        public void acceptMarks()
        {
            Console.WriteLine("Enter CSharp Marks, HTML Marks, SQL Marks : ");
            CSharp = Convert.ToInt32(Console.ReadLine());
            HTML = Convert.ToInt32(Console.ReadLine());
            Sql = Convert.ToInt32(Console.ReadLine());
        }

        public float average()
        {
            float average;
            average = (CSharp + HTML + Sql) / 3;
            return average;
        }

        public void Result(float avg)
        {
            if(avg < 50)
            {
                Console.WriteLine("The Student has not Passed the Exam!!!!!");
            }
            else
            {
                Console.WriteLine("The Student has Passed the Exam!!!!!!");
            }
        }

        static void Main(string[] args)
        {
            float Average;
            Assignment_Q4 assign = new Assignment_Q4();
            Console.WriteLine("Enter the Marks for First Student");
            assign.acceptMarks();
            Average = assign.average();
            assign.Result(Average);
            Console.WriteLine("Enter the Marks for Second Student");
            assign.acceptMarks();
            Average = assign.average();
            assign.Result(Average);
            Console.WriteLine("Enter the Marks for Third Student");
            assign.acceptMarks();
            Average = assign.average();
            assign.Result(Average);
            Console.WriteLine("Enter the Marks for Fourth Student");
            assign.acceptMarks();
            Average = assign.average();
            assign.Result(Average);
            Console.WriteLine("Enter the Marks for Fifth Student");
            assign.acceptMarks();
            Average = assign.average();
            assign.Result(Average);
        }
    }
}
