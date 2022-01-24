using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Assignment_1
{
    class Assignment_Q3
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Please Input 3 Numbers for Comparision");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());

            if((num1 > num2) && (num1 > num3))
            {
                Console.WriteLine("The Largest Number is  : {0}",num1);
            }
            else if((num2 > num1) && (num2 > num3))
            {
                Console.WriteLine("The Largest Number is  : {0}", num2);
            }
            else if((num3 > num1) && (num3 > num2))
            {
                Console.WriteLine("The Largest Number is  : {0}", num3);
            }

            if ((num1 < num2) && (num1 < num3))
            {
                Console.WriteLine("The Smallest Number is  : {0}", num1);
            }
            else if ((num2 < num1) && (num2 < num3))
            {
                Console.WriteLine("The Smallest Number is  : {0}", num2);
            }
            else if ((num3 < num1) && (num3 < num2))
            {
                Console.WriteLine("The Smallest Number is  : {0}", num3);
            }

            // Console.WriteLine(num1 + num2 + num3);
        }
    }
}
