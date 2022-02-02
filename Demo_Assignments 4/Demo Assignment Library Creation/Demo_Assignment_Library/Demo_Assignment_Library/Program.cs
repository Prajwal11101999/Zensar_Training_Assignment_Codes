using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateConcession_Library;

namespace Demo_Assignment_Library
{
    class Program
    {
        public const int ToolFare = 500;
        static void Main(string[] args)
        {
            // int Fare = ToolFare;
            string Cust_Name;
            int Cust_Age;
            Console.WriteLine("Please Enter the Name: ");
            Cust_Name = Console.ReadLine();
            Console.WriteLine("Please Enter the Age : ");
            Cust_Age = int.Parse(Console.ReadLine());
            Calculate_Method cm = new Calculate_Method();
            cm.CalculateConcession(Cust_Age, ToolFare);
        }
    }
}
