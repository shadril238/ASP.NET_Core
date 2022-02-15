///Author: Shifat, Shadril Hassan [20-42451-1]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Task3
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(j + i);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
