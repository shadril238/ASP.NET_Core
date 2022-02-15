///Author: Shifat, Shadril Hassan [20-42451-1]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of n to find all even numbers from 1 to n : ");
            int n = Convert.ToInt32(Console.ReadLine());

            
            if (n <= 1)
            {
                Console.WriteLine("Input Error!");
                return;
            }
            Console.Write("All even numbers from 1 to " + n + " : ");
            for (int i = 2; i <= n; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
