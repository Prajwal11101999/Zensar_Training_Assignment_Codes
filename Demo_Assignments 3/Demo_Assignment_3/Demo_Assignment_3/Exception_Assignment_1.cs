using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Assignment_3
{
    class TicketBookingException : ApplicationException
    {
        public TicketBookingException(string msg):base(msg)
        {

        }
    }

    class TicketBooking_Passanger
    {
        public int Age;
        public string Name;
        public void TicketBooking(int no_of_tickets)
        {
            if(no_of_tickets > 5)
            {
                throw (new TicketBookingException("Cannot Book more than 5 Tickets."));
            }
            else
            {
                Console.WriteLine("Ticket Booked Successfully!!!!!!!!!!!!!!");
            }
        }
    }

    class Exception_Assignment_1
    {
        static void Main(string[] args)
        {
            int tickets;
            TicketBooking_Passanger tbp = new TicketBooking_Passanger();
            try
            {
                Console.WriteLine("Enter Name : ");
                tbp.Name = Console.ReadLine();
                Console.WriteLine("Enter Age : ");
                tbp.Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Number of tickets to book : ");
                tickets = int.Parse(Console.ReadLine());
                tbp.TicketBooking(tickets);
            }
            catch(TicketBookingException tbe)
            {
                Console.WriteLine(tbe.Message);
            }
        }
    }
}
