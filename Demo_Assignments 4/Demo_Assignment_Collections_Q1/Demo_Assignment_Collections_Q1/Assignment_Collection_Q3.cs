using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Assignment_Collections_Q1
{
    class Assignment_Collection_Q3
    {
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>();
            Console.WriteLine("Enter the Number of Elements to be  entered in a List : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Elements in the List :");
            for (int j = 0; j < num; j++)
            {
                Console.Write("Element : ");
                mylist.Add(int.Parse(Console.ReadLine()));
            }
            mylist.Sort();
            Console.WriteLine("The Elements in the Lists are : ");
            foreach (int items in mylist)
            {
                Console.WriteLine("Element : " + items);
            }
            
        }
    }
}
