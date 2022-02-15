///Author: Shifat, Shadril Hassan [20-42451-1]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Task7
    {
        static void Main(string[] args)
        {
            string tmp = "*";
            for(int i=1; i<=9; i++)
            {
                if (i < 5)
                {
                    Console.WriteLine(tmp);
                    tmp += "*";
                }
                else
                {
                    Console.WriteLine(tmp);
                    tmp = tmp.Remove(tmp.Length - 1); 
                }
            }
            Console.WriteLine(); 
        }
    }
}
