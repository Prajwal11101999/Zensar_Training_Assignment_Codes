using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Assignment_3
{
    
    struct Books_Details
    {
        public string Book_Name { get; set; }
        public string Author_Name { get; set; }
        public string Publisher_Name {get; set; }
        public DateTime Dt0fPublish { get; set; }
        private int Book_ID;
        public int bookid
        {
            get
            {
                return Book_ID;
            }
            set
            {
                Book_ID = value;
            }
        }


        public void Display()
        {
            Console.WriteLine("The ID of Book is : " + Book_ID);
            Console.WriteLine("The Name of Book is : " + Book_Name);
            Console.WriteLine("The Author of Book is : " + Author_Name);
            Console.WriteLine("Thes Publisher of Book is : " + Publisher_Name);
            Console.WriteLine("The Date of Release of Book is : " + Dt0fPublish);
        }
    }
    class Structure_Assignment
    {
        static void Main(string[] args)
        {
            Books_Details bd = new Books_Details();
            bd.bookid = 1001;
            bd.Book_Name = "Harry Potter and the Deathly Hallows.";
            bd.Author_Name = "J. K. Rowling";
            bd.Publisher_Name = "Bloomsbury(UK)";
            bd.Dt0fPublish = DateTime.Parse("14/07/2007");
            bd.Display();
            Console.WriteLine();
            bd.bookid = 1002;
            bd.Book_Name = "Harry Potter and the Half Blood Prince.";
            bd.Author_Name = "J. K. Rowling";
            bd.Publisher_Name = "Bloomsbury(UK)";
            bd.Dt0fPublish = DateTime.Parse("16/07/2005");
            bd.Display();
            Console.WriteLine();
            bd.bookid = 1003;
            bd.Book_Name = "Harry Potter and the Order of the Phoenix.";
            bd.Author_Name = "J. K. Rowling";
            bd.Publisher_Name = "Bloomsbury(UK)";
            bd.Dt0fPublish = DateTime.Parse("23/06/2003");
            bd.Display();
            Console.WriteLine();
            bd.bookid = 1004;
            bd.Book_Name = "Harry Potter and the Goblet of Fire.";
            bd.Author_Name = "J. K. Rowling";
            bd.Publisher_Name = "Bloomsbury(UK)";
            bd.Dt0fPublish = DateTime.Parse("08/07/2000");
            bd.Display();
            Console.WriteLine();
            bd.bookid = 1005;
            bd.Book_Name = "Harry Potter and the Prisoner of Askaban.";
            bd.Author_Name = "J. K. Rowling";
            bd.Publisher_Name = "Bloomsbury(UK)";
            bd.Dt0fPublish = DateTime.Parse("08/07/1999");
            bd.Display();
            Console.WriteLine();
            bd.bookid = 1006;
            bd.Book_Name = "Harry Potter and the Chamber of Secrets.";
            bd.Author_Name = "J. K. Rowling";
            bd.Publisher_Name = "Bloomsbury(UK)";
            bd.Dt0fPublish = DateTime.Parse("02/07/1998");
            bd.Display();
            Console.WriteLine();
            bd.bookid = 1007;
            bd.Book_Name = "Harry Potter and the Philosopher's Stone.";
            bd.Author_Name = "J. K. Rowling";
            bd.Publisher_Name = "Bloomsbury(UK)";
            bd.Dt0fPublish = DateTime.Parse("26/06/1997");
            bd.Display();
        }
    }
}
