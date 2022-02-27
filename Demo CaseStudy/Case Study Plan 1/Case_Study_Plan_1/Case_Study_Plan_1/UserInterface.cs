using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_Plan_1
{
    abstract class UserInterface
    {
		public abstract void showFirstScreen(Student[] student);
		public abstract void showStudentScreen(Student[] student);
		public abstract void showAdminScreen();
		public abstract void showAllStudentsScreen();
		public abstract void showStudentRegistrationScreen(); // Execute the register method of AppEngine class
		public abstract void introduceNewCourseScreen();
		public abstract void showAllCoursesScreen();
	}
	class BackEnd : UserInterface
    {
		public override void showFirstScreen(Student[] student)
		{
			Console.WriteLine("Welcome to SMS(Student Mgmt. System) v1.0");
			Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin");
			Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
			int op = Convert.ToInt32(Console.ReadLine());

			switch (op)
			{
				case 1:
					showStudentScreen(student);
					break;
				case 2:
					showAdminScreen();
					break;
			}
		}

        public override void showStudentScreen(Student[] student)
        {
            Console.WriteLine("Welcome to Student Screen : ");
            Console.WriteLine("Do you want to see : \n1. Student Info \n2. New Registration");
			Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
			int op = Convert.ToInt32(Console.ReadLine());

			switch (op)
			{
				case 1:
                    Console.WriteLine("Enter your Student ID : ");
					int id = int.Parse(Console.ReadLine());
                    for (int i = 0; i < student.Length; i++)
                    {
						if(student[i].Student_Id == id)
                        {
							Info info = new Info();
							info.Display();
                        }
                    }
					break;
				case 2:

					break;
			}
		}

        public override void showAdminScreen()
        {
            throw new NotImplementedException();
        }

        public override void introduceNewCourseScreen()
        {
            throw new NotImplementedException();
        }

        public override void showStudentRegistrationScreen()
        {
            throw new NotImplementedException();
        }

        public override void showAllStudentsScreen()
        {
            throw new NotImplementedException();
        }

        public override void showAllCoursesScreen()
        {
            throw new NotImplementedException();
        }
    }
}
