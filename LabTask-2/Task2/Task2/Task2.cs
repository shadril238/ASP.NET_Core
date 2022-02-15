///Author: Shifat, Shadril Hassan [20-42451-1]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write('X');
                        }
                        else
                        {
                            Console.Write('0');
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write('0');
                        }
                        else
                        {
                            Console.Write('X');
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
