///Author: Shifat, Shadril Hassan [20-42451-1]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Task5
    {
        static void Main(string[] args)
        {
            string tmp = "";
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(tmp + i);
                tmp += " ";
            }
            Console.WriteLine();
        }
    }
}
