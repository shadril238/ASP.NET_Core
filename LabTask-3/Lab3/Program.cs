//Author: Shadril Hassan Shifat [20-42451-1] 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object for Student Class
            Student shadril = new Student();
            shadril.Name = "Shadril Hassan Shifat";
            shadril.Id = "20-42451-1";
            shadril.Department = "CSE";
            shadril.Cgpa = 3.95f;
            shadril.ShowInfo();
            Console.WriteLine();//newline

            //Object for Triangle class
            Triangle triangle = new Triangle();
            triangle.X = 6;
            triangle.Y = 7;
            triangle.Z = 6;
            triangle.ShowInfo();
            triangle.TestTriangle();
            Console.WriteLine();//newline

            //Object for Account class
            Account account = new Account();
            account.AccName = "Shadril Hassan";
            account.Acid = "SMSA-20424511";
            account.Balance = 5000;
            Console.WriteLine("Account Balance : " + account.Balance);
            account.Deposit(3000);
            account.Withdraw(500);

            Account account1 = new Account("Leen", "SMSA-121020", 1000);
            account.Transfer(2000, account1);//transfer from account to account1
            Console.WriteLine(); ///Account Balace will be shown here.

            //Console.WriteLine();//newline

            //Object for Course class
            Course course = new Course();
            course.CourseName = "OOP2-C#";
            course.CourseCode = "DN0109";
            course.courseCredit = 3;
            course.ShowCourseInfo();
            Console.WriteLine();//newline
        }
    }
}
