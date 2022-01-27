using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Assignment2
{

    class Accounts
    {
        public string Account_No;
        public string Customer_Name;
        public string Account_Type;
        public float amount;
        public float balance;

        public Accounts(string an, string cn, string at, float bal)
        {
            Account_No = an;
            Customer_Name = cn;
            Account_Type = at;
            balance = bal;
        }

        public void ShowAccountDetails()
        {
            Console.WriteLine("The Account Number is : {0} ", Account_No);
            Console.WriteLine("The Customer Name is : {0} ", Customer_Name);
            Console.WriteLine("The Account Type is : {0} ", Account_Type);
            Console.WriteLine("The Total Balance in Account is : {0}", balance);
        }

        public int Trans_dep_Wid()
        {
            int n;
            char ans;
            Console.WriteLine("***************************Types of Transaction************************************");
            do
            {
                Console.WriteLine("\t 1. Deposit   \n\t 2. Withdrawal ");
                Console.WriteLine("Enter your Choice : ");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Enter the Amount to be Deposited : ");
                        amount = int.Parse(Console.ReadLine());
                        balance = balance + amount;
                        Console.WriteLine($"The Total Balance after the Deposit Operation \n Amount to Deposit : {amount} \n Balance after Depositing the Amount : {balance} ");
                        break;
                    case 2:
                        Console.WriteLine("Enter the Amount to be Withdrawal : ");
                        amount = int.Parse(Console.ReadLine());
                        balance = balance - amount;
                        Console.WriteLine($"The Total Balance after the Withdrawal Operation \n Amount to Withdraw : {amount} \n Balance after Withdrawing the Amount : {balance} ");
                        break;
                    default:
                        Console.WriteLine("The Input is Invalid!!!!!!!!!!!!!!!!!!!");
                        break;
                }
                Console.WriteLine("Do You Want to continue : y or n");
                ans = char.Parse(Console.ReadLine());
            } while ((ans == 'y') || (ans == 'Y')); 

            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Accounts Acc = new Accounts("CBIACNO9876543", "Prajwal Borawake", "Savings", 400000f);
            Acc.ShowAccountDetails();
            Acc.Trans_dep_Wid();

        }
    }
}
