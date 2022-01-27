using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Assignment_String
{
    class String_Assig_1
    {
        static void Main(string[] args)
        {
            string str;
            int str_len;
            Console.WriteLine("Enter the String : ");
            str = Console.ReadLine();
            Console.WriteLine("The String Entered is : {0}", str);
            str_len = str.Length;
            Console.WriteLine("The Length of String is : {0}", str_len);
        }
    }
}
