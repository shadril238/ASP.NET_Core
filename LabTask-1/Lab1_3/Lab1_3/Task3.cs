///Shadril Hassan Shifat [20-42451-1]
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_3
{
    internal class Task3
    {
        static void Main(string[] args)
        {
            int value = 5001;
            double sq = Math.Sqrt(value);
            bool flag = true;
            if (value == 1)
            {
                Console.WriteLine(value + " is not a prime number");
            }
            else
            {
                for (int i = 2; i <= sq; i++)
                {
                    if (value % i == 0)
                    {
                        Console.WriteLine(value + " is not a prime number");
                        flag = false;
                        break;
                    }

                }
                if (flag)
                {
                    Console.WriteLine(value + " is a prime number");
                }
            }
        }
    }
}