///Shadril Hassan Shifat [20-42451-1]
///Character Count
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_1
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();
            int len = name.Length, cnt = 0;
            for (int i = 0; i < len; i++)
            {
                if ((name[i] >= 'A' || name[i] >= 'a') && (name[i] <= 'Z' || name[i] <= 'z')) cnt++;
            }
            Console.WriteLine("Total number of characters in the name : " + cnt);
        }
    }
}