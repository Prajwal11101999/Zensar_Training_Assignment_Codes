using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Array_Assignment
{
    class Assignment_Array1
    {
        static void Main(string[] args)
        {
            // int[] arr;
            int size;
            int total = 0;
            // double average;

            Console.WriteLine("Enter the Size of Array");
            size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the {0} Elements in the Array", size);
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < size; i++)
            {
                total = total + arr[i];
            }
            // double average = total / size;
            double average = Queryable.Average(arr.AsQueryable());
            Console.WriteLine("The average of elements of the array is : " + average);

            Array.Sort(arr);

            Console.WriteLine("The Minimum value is : {0}, Maximum value is : {1}.", arr[0],arr[size-1]);
            
            /*
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
            }
            */
        }
    }
}
