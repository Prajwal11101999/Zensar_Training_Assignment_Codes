using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Array_Assignment
{
    class Assignment_ArrayQ2
    {
        public int[] arr = new int[10];
        public int total = 0;
        public double average;
        

        public void AcceptElements()
        {
            Console.WriteLine("Enter 10 Subjects Marks.");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Tolal_Average()
        {
            for (int i = 0; i < 10; i++)
            {
                total = total + arr[i];
            }
            Console.WriteLine("The Sum of 10 Subjects Marks is : {0}.",total);

            average = Queryable.Average(arr.AsQueryable());
            Console.WriteLine("The Average of 10 Subjects Marks is : {0}",average);

        }

        public void Min_Max_Marks()
        {
            Array.Sort(arr);
            Console.WriteLine("The Minimum value is : {0}, Maximum value is : {1}.", arr[0], arr[9]);
        }

        public void Ascend_Descend()
        {
            Array.Sort(arr);
            Console.WriteLine("The Marks in Ascending Order: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\t" + arr[i]);
            }

            Array.Reverse(arr);
            Console.WriteLine("\n The Marks in Descending Order: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\t" + arr[i]);
            }
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            Assignment_ArrayQ2 assign = new Assignment_ArrayQ2();
            assign.AcceptElements();
            assign.Tolal_Average();
            assign.Min_Max_Marks();
            assign.Ascend_Descend();
        }
    }
}
