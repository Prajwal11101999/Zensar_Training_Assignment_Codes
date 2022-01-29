using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Assignment_3
{
    struct Book_Details
    {
        public string Book_Name;
        public string Author_Name;
    }
    class Nested_Structure_Assignment_2
    {
        static void Main(string[] args)
        {
            int Number_Books;
            int k = 1;
            Console.WriteLine("Enter the Number of Books information to be Entered : ");
            Number_Books = int.Parse(Console.ReadLine());
            Books_Details[] books_info = new Books_Details[Number_Books];
            Console.WriteLine($"Insert the Information of {Number_Books} Books : ");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            for (int i = 0; i < Number_Books; i++)
            {
                Console.WriteLine($"Information of Book Number : {k}");

                Console.Write("Input Name of the Book : ");
                books_info[i].Book_Name = Console.ReadLine();

                Console.Write("Input Name of the Author : ");
                books_info[i].Author_Name = Console.ReadLine();

                k++;
                Console.WriteLine();
            }
            for (int i = 0; i < Number_Books; i++)
            {
                Console.WriteLine($"{i+1}: Title = {books_info[i].Book_Name}, Author = {books_info[i].Author_Name}");
            }
        }
    }
}
