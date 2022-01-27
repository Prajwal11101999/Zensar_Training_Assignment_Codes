using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Assignment_String
{
    class String_Assig_3
    {
        static void Main(string[] args)
        {
            string str1;
            string str2;
            Console.WriteLine("Enter the First String : ");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter the Second String : ");
            str2 = Console.ReadLine();

            if(str1 == str2)
            {
                Console.WriteLine("The Both Entered String are same.");
            }
            else
            {
                Console.WriteLine("The Both Entered String are not same.");
            }     
        }
    }
}
