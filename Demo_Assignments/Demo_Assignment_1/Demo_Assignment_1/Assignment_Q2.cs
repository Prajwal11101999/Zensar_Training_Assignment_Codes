using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Assignment_1
{
    class Assignment_Q2
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Please enter any number : ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num%2 == 0)
            {
                Console.WriteLine("The Given Number : {0}, is Even Number.",num);
            }
            else
            {
                Console.WriteLine("The Given Number : {0}, is Odd Number.",num);
            }
        }
    }
}
