using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Assignment_3
{
    public struct EmpDetails
    {
        public string E_Name;
        public int E_ID;
        public string C_Name;
        public double E_Salary;
        public dateinfo Date;
        public dateinfo Date1;
    }

    public struct dateinfo
    {
        public int Day;
        public int Month;
        public int Year;
    }

    class Nested_Structure_Assignment_1
    {
        static void Main(string[] args)
        {
            int day = 0;
            int month = 0;
            int year = 0;
            int size = 0;
            Console.WriteLine("*****************************Example of Nested Structure*****************************");
            Console.WriteLine("Enter the Number of Employees Data to submit : ");
            size = int.Parse(Console.ReadLine());
            EmpDetails[] ede = new EmpDetails[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Name of the employee : ");
                string nm = Console.ReadLine();
                ede[i].E_Name = nm;

                Console.Write("Employee ID of the employee : ");
                int eid = int.Parse(Console.ReadLine());
                ede[i].E_ID = eid;

                Console.Write("Name of the Employees Company  : ");
                string C_nm = Console.ReadLine();
                ede[i].C_Name = C_nm;

                Console.Write("Salary of the employee : ");
                double sal = double.Parse(Console.ReadLine());
                ede[i].E_Salary = sal;

                Console.Write("Input day of the Joining : ");
                day = Convert.ToInt32(Console.ReadLine());
                ede[i].Date.Day = day;

                Console.Write("Input month of the Joining : ");
                month = Convert.ToInt32(Console.ReadLine());
                ede[i].Date.Month = month;

                Console.Write("Input year for the Joining : ");
                year = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine();
                ede[i].Date.Year = year;

                Console.Write("Input day of the Birth : ");
                day = Convert.ToInt32(Console.ReadLine());
                ede[i].Date1.Day = day;

                Console.Write("Input month of the Birth : ");
                month = Convert.ToInt32(Console.ReadLine());
                ede[i].Date1.Month = month;

                Console.Write("Input year for the Birth : ");
                year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                ede[i].Date1.Year = year;
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Empmoyee ID : " + ede[i].E_ID);
                Console.WriteLine("Empmoyee Name : " + ede[i].E_Name);
                Console.WriteLine("Empmoyee Company Name : " + ede[i].C_Name);
                Console.WriteLine("Empmoyee Salary : " + ede[i].E_Salary);
                Console.WriteLine("Empmoyee Date of Joining : " + ede[i].Date.Day + "/" + ede[i].Date.Month + "/" + ede[i].Date.Year);
                Console.WriteLine("Empmoyee Date of Birth : " + ede[i].Date1.Day + "/" + ede[i].Date1.Month + "/" + ede[i].Date1.Year);
            }
        }
    }
}
