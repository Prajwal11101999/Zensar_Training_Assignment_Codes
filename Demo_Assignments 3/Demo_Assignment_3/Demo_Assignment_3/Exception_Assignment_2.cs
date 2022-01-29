using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Assignment_3
{
    class LoanProcessException : ApplicationException
    {
        public LoanProcessException(string msg) : base(msg)
        {

        }
    }

    class LoanProcess
    {
        int Loan_No;
        string Customer_Name;
        double Loan_Amount;
        double EMI_Amount;
        double Account_Balance;

        public LoanProcess(int ln, string cn, double la, double ab)
        {
            Loan_No = ln;
            Customer_Name = cn;
            Loan_Amount = la;
            Account_Balance = ab;
        }

        public void calculate_EMI()
        {
            EMI_Amount = (Loan_Amount * (13 / 12 / 100) * (1 + (13 / 13 / 100)) * 36) / ((1 + (13 / 12 / 100)) * (36 - 1));
        }

        public void CheckBalance()
        {
            if(Account_Balance < EMI_Amount)
            {
                throw (new LoanProcessException("The Amount of EMI is Biger than Account Balance."));
            }
            else
            {
                Console.WriteLine("The Loan is Accepted and is processing!!!!!!!!!! ");
            }
        }

    }

    class Exception_Assignment_2
    {
        static void Main(string[] args)
        {
            LoanProcess lp = new LoanProcess(65852, "Prajwal", 1000000.00, 500.98);
            try
            {
                lp.calculate_EMI();
                lp.CheckBalance();
            }
            catch(LoanProcessException lpe)
            {
                Console.WriteLine(lpe.Message);
            }
            finally
            {
                Console.WriteLine("Not Sufficient Balance to repay Loan");
            }
        }
    }
}
