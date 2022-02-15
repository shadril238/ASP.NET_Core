///Author: Shifat, Shadril Hassan [20-42451-1]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Task4
    {
        static void Main(string[] args)
        {
            int evenSum = 0, oddSum = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                }
                else
                {
                    oddSum += i;
                }
            }
            Console.WriteLine("Sum of even numbers from 1 to 100 : " + evenSum);
            Console.WriteLine("Sum of odd numbers from 1 to 100 : " + oddSum);
        }
    }
}
