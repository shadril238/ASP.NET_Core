///Author: Shifat, Shadril Hassan [20-42451-1]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Task6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Factorial of " + n + " is ");
            for (int i = 1; i <= n; i++)
            {
                if (i < n)
                {
                    Console.Write(i + "*");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();
        }
    }
}
