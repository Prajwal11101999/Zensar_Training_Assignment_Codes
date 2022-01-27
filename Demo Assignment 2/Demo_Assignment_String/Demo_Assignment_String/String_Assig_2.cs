using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Assignment_String
{
    class String_Assig_2
    {
        static void Main(string[] args)
        {
            string str;
            int str_len;
            string rev_str="";
            Console.WriteLine("Enter the String : ");
            str = Console.ReadLine();
            Console.WriteLine("The String Entered is : {0}", str);
            str_len = str.Length - 1;
            while(str_len >= 0)
            {
                rev_str = rev_str + str[str_len];
                str_len--;
            }
            Console.WriteLine("The Reversed String Entered is : {0}",rev_str);
        }
    }
}
