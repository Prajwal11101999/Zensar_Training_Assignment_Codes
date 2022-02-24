using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToObject_Assignment5
{

    class Employee
    {

        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }

    }

    class MainProgramExec
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>()
            {
                new Employee()
                {
                   EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = Convert.ToDateTime("16/11/1984"), DOJ = Convert.ToDateTime("8/6/2011"), City = "Mumbai"
                },
                new Employee()
                {
                   EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = Convert.ToDateTime("20/08/1984"), DOJ = Convert.ToDateTime("7/7/2012"), City = "Mumbai"
                },
                new Employee()
                {
                   EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = Convert.ToDateTime("14/11/1987"), DOJ = Convert.ToDateTime("12/4/2015"), City = "Pune"
                },
                new Employee()
                {
                   EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = Convert.ToDateTime("3/6/1990"), DOJ = Convert.ToDateTime("2/2/2016"), City = "Pune"
                },
                new Employee()
                {
                   EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = Convert.ToDateTime("8/3/1991"), DOJ = Convert.ToDateTime("2/2/2016"), City = "Mumbai"
                },
                new Employee()
                {
                   EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = Convert.ToDateTime("7/11/1989"), DOJ = Convert.ToDateTime("8/8/2014"), City = "Chennai"
                },
                new Employee()
                {
                   EmployeeID = 1007, FirstName = "Vijay", LastName = "Natranjan", Title = "Consultant", DOB = Convert.ToDateTime("2/12/1989"), DOJ = Convert.ToDateTime("1/6/2015"), City = "Mumbai"
                },
                new Employee()
                {
                   EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = Convert.ToDateTime("11/11/1993"), DOJ = Convert.ToDateTime("6/11/2014"), City = "Chennai"
                },
                new Employee()
                {
                   EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = Convert.ToDateTime("12/8/1992"), DOJ = Convert.ToDateTime("3/12/2014"), City = "Chennai"
                },
                new Employee()
                {
                   EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = Convert.ToDateTime("12/4/1991"), DOJ = Convert.ToDateTime("2/1/2016"), City = "Pune"
                }
            };
            
            // a. Display detail of all the employee
            var displayallelements = from disp in empList
                                     select disp;
            foreach (var item in displayallelements)
            {
                Console.WriteLine("Employee Id : {0}",item.EmployeeID);
                Console.WriteLine("Employee First Name : {0}", item.FirstName);
                Console.WriteLine("Employee Last Name : {0}", item.LastName);
                Console.WriteLine("Employee Job Title : {0}", item.Title);
                Console.WriteLine("Employee Date of Birth : {0}", item.DOB);
                Console.WriteLine("Employee Date of Joining : {0}", item.DOJ);
                Console.WriteLine("Employee Working City : {0}", item.City);
                Console.WriteLine("************************************************************************************************************************");
            }

            // b. Display details of all the employee whose location is not Mumbai
            var displayempnomum = from disp in empList
                                  where disp.City != "Mumbai"
                                  select disp;
            foreach (var item in displayempnomum)
            {
                Console.WriteLine("Employee Id : {0}", item.EmployeeID);
                Console.WriteLine("Employee First Name : {0}", item.FirstName);
                Console.WriteLine("Employee Last Name : {0}", item.LastName);
                Console.WriteLine("Employee Job Title : {0}", item.Title);
                Console.WriteLine("Employee Date of Birth : {0}", item.DOB);
                Console.WriteLine("Employee Date of Joining : {0}", item.DOJ);
                Console.WriteLine("Employee Working City : {0}", item.City);
                Console.WriteLine("************************************************************************************************************************");
            }
            
            // c. Display details of all the employee whose title is AsstManager
            var displayemp_astmg = from disp in empList
                                  where disp.Title == "AsstManager"
                                  select disp;
            foreach (var item in displayemp_astmg)
            {
                Console.WriteLine("Employee Id : {0}", item.EmployeeID);
                Console.WriteLine("Employee First Name : {0}", item.FirstName);
                Console.WriteLine("Employee Last Name : {0}", item.LastName);
                Console.WriteLine("Employee Job Title : {0}", item.Title);
                Console.WriteLine("Employee Date of Birth : {0}", item.DOB);
                Console.WriteLine("Employee Date of Joining : {0}", item.DOJ);
                Console.WriteLine("Employee Working City : {0}", item.City);
                Console.WriteLine("************************************************************************************************************************");
            }
            

            // d. Display details of all the employee whose Last Name start with S
            var displayempname_s = from disp in empList
                                   where disp.LastName.Contains("S")
                                   select disp;
            foreach (var item in displayempname_s)
            {
                Console.WriteLine("Employee Id : {0}", item.EmployeeID);
                Console.WriteLine("Employee First Name : {0}", item.FirstName);
                Console.WriteLine("Employee Last Name : {0}", item.LastName);
                Console.WriteLine("Employee Job Title : {0}", item.Title);
                Console.WriteLine("Employee Date of Birth : {0}", item.DOB);
                Console.WriteLine("Employee Date of Joining : {0}", item.DOJ);
                Console.WriteLine("Employee Working City : {0}", item.City);
                Console.WriteLine("************************************************************************************************************************");
            }
            
            // e. Display a list of all the employee who have joined before 1/1/2015
            var displayempjoinbe = from disp in empList
                                   where disp.DOJ < Convert.ToDateTime("1/1/2015")
                                   select disp;
            foreach (var item in displayempjoinbe)
            {
                Console.WriteLine("Employee Id : {0}", item.EmployeeID);
                Console.WriteLine("Employee First Name : {0}", item.FirstName);
                Console.WriteLine("Employee Last Name : {0}", item.LastName);
                Console.WriteLine("Employee Job Title : {0}", item.Title);
                Console.WriteLine("Employee Date of Birth : {0}", item.DOB);
                Console.WriteLine("Employee Date of Joining : {0}", item.DOJ);
                Console.WriteLine("Employee Working City : {0}", item.City);
                Console.WriteLine("************************************************************************************************************************");
            }
            
            // f. Display a list of all the employee whose date of birth is after 1/1/1990
            var displayempdobaft = from disp in empList
                                   where disp.DOB > Convert.ToDateTime("1/1/1990")
                                   select disp;
            foreach (var item in displayempdobaft)
            {
                Console.WriteLine("Employee Id : {0}", item.EmployeeID);
                Console.WriteLine("Employee First Name : {0}", item.FirstName);
                Console.WriteLine("Employee Last Name : {0}", item.LastName);
                Console.WriteLine("Employee Job Title : {0}", item.Title);
                Console.WriteLine("Employee Date of Birth : {0}", item.DOB);
                Console.WriteLine("Employee Date of Joining : {0}", item.DOJ);
                Console.WriteLine("Employee Working City : {0}", item.City);
                Console.WriteLine("************************************************************************************************************************");
            }
            
            // g. Display a list of all the employee whose designation is Consultant and Associate
            var displayempdesig = from disp in empList
                                   where disp.Title == "Consultant" || disp.Title == "Associate"
                                   select disp;
            foreach (var item in displayempdesig)
            {
                Console.WriteLine("Employee Id : {0}", item.EmployeeID);
                Console.WriteLine("Employee First Name : {0}", item.FirstName);
                Console.WriteLine("Employee Last Name : {0}", item.LastName);
                Console.WriteLine("Employee Job Title : {0}", item.Title);
                Console.WriteLine("Employee Date of Birth : {0}", item.DOB);
                Console.WriteLine("Employee Date of Joining : {0}", item.DOJ);
                Console.WriteLine("Employee Working City : {0}", item.City);
                Console.WriteLine("************************************************************************************************************************");
            }
            
            // h. Display total number of employees
            var displaytotalnoemp = empList.Count();    //from disp in empList
                                                        // where disp.Title == "Consultant" || disp.Title == "Associate"
                                                        // select disp;
            Console.WriteLine("Total Number of Employees : {0} ", displaytotalnoemp);
            
            // i. Display total number of employees belonging to “Chennai”
            var displayempnochen = from disp in empList
                                   where disp.City == "Chennai"
                                   select disp;
            Console.WriteLine("Total Numbers Employee Belonging to City Chennai : {0} ", displayempnochen.Count());
            
            // j. Display highest employee id from the list
            var displayhighempid = empList.Max(disp => disp.EmployeeID);
            Console.WriteLine("The Highest Employee Id : {0} ", displayhighempid);
            
            // k. Display total number of employee who have joined after 1/1/2015
            var displayempjoin = from disp in empList
                                 where disp.DOJ > Convert.ToDateTime("1/1/2015")
                                 select disp;
            Console.WriteLine("The Total Numbers of Employees who have Joined after 1/1/2015 : {0} ", displayempjoin.Count());
            
            // l. Display total number of employee whose designation is not “Associate”
            var displaydesignoasso = from disp in empList
                                     where disp.Title != "Associate"
                                     select disp;
            Console.WriteLine("The Total Number of Employee whose Designation is not 'Associate' : {0} ", displaydesignoasso.Count());
            
            // m. Display total number of employee based on City
            var displaynoempbycity = from disp in empList
                                     group disp by disp.City into disp1
                                     select new { count = disp1.Count(), disp1.First().City,};
            foreach (var item in displaynoempbycity)
            {
                Console.WriteLine("Number of EMployees : {0} in City : {1} ",item.count,item.City);
            }
            
            // n. Display total number of employee based on city and title
            var displaynoempbycitytitle = (from q in empList
                       group q by (q.City, q.Title) into city
                       orderby city.Key
                       select city);
            foreach (var item in displaynoempbycitytitle)
            {
                Console.Write($"ID: {item.Key}\t");
                Console.WriteLine($"{item.Count()}");
            }
            
            // o. Display total number of employee who is youngest in the list
            var displayempyoung = from disp in empList
                                  where disp.DOB == ((from d in empList select d.DOB).Max())
                                  select disp;
            Console.WriteLine("The Youngest Employee : ");
            foreach (var item in displayempyoung)
            {
                Console.WriteLine("Employee Id : {0}", item.EmployeeID);
                Console.WriteLine("Employee First Name : {0}", item.FirstName);
                Console.WriteLine("Employee Last Name : {0}", item.LastName);
                Console.WriteLine("Employee Job Title : {0}", item.Title);
                Console.WriteLine("Employee Date of Birth : {0}", item.DOB);
                Console.WriteLine("Employee Date of Joining : {0}", item.DOJ);
                Console.WriteLine("Employee Working City : {0}", item.City);
            }
        }
    }
}
