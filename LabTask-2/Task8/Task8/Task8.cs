//Author: Shifat, Shadril Hassan [20-42451-1]
///Task-8
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{   
    internal class Task8
    {
        static string gradeCalculation(float marks)
        {
            if(marks >= 90)
            {
                return "A+";
            }
            else if(marks >= 85)
            {
                return "A";
            }
            else if( marks >= 80)
            {
                return "B+";
            }
            else if (marks >= 75)
            {
                return "B";
            }
            else if(marks >= 50)
            {
                return "C+";
            }
            return "F";
        }

        static void Main(string[] args)
        {
            Console.Write("Input the marks of Physics : ");
            float physics=Convert.ToSingle(Console.ReadLine());

            Console.Write("Input the marks of Chemistry : ");
            float chemistry = Convert.ToSingle(Console.ReadLine());

            Console.Write("Input the marks of Biology : ");
            float biology = Convert.ToSingle(Console.ReadLine());

            Console.Write("Input the marks of Mathematics : ");
            float math = Convert.ToSingle(Console.ReadLine());

            Console.Write("Input the marks of Computer : ");
            float computer = Convert.ToSingle(Console.ReadLine());

            float percentage= (physics+ chemistry + biology+ math + computer)/5;

            Console.WriteLine("Percentage : " + percentage);

            Console.WriteLine("Grade in Physics : " + gradeCalculation(physics));
            Console.WriteLine("Grade in Chemistry : " + gradeCalculation(chemistry));
            Console.WriteLine("Grade in Biology : " + gradeCalculation(biology));
            Console.WriteLine("Grade in Mathematics : " + gradeCalculation(math));
            Console.WriteLine("Grade in Computer : " + gradeCalculation(computer));


        }
    }
}
