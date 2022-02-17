//Author: shadril238
//Instructor: Victor Stany 
//Lecture-2 :: In this program, I worked with different assembly and add references of a class library to a console application.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_Task1; 
namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student shadril = new Student();
            shadril.setValues(7, "20-42451-1", "Shadril Hassan Shifat", 3.95f);
            shadril.displayValues();

        }
    }
}
