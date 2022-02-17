//Author: shadril238

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_ID_CGPA_Sem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter your name: ");
            string name=System.Console.ReadLine();
            System.Console.Write("Enter your ID: ");
            string id = System.Console.ReadLine();
            System.Console.Write("Enter your CGPA: ");
            double cgpa = System.Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("Enter your total semester: ");
            int sem = System.Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Name: " + name + "\n" + "ID: " + id + "\n" + "CGPA: " + cgpa + "\n" + "Total Semester: " + sem + "\n");

        }
    }
}
