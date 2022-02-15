//Author: Shadril Hassan Shifat [20-42451-1] 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Triangle
    {
        private int x, y, z;
        public Triangle()
        {
            Console.WriteLine("Default constructor of Triangle class is called.");
        }

        public int X
        {
            get 
            { 
                return x; 
            }
            set 
            { 
                x = value; 
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public int Z
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Size X of the triangle : " + this.x);
            Console.WriteLine("Size Y of the triangle : " + this.y);
            Console.WriteLine("Size Z of the triangle : " + this.z);

        }
        public void TestTriangle()
        {
            if(this.x == this.y && this.y == this.z)
            {
                Console.WriteLine("The triangle is equilateral.");
            }
            else if(this.x == this.y || this.y == this.z || this.x == this.z)
            {
                Console.WriteLine("The triangle is isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is scalene.");
            }
        }

    }
}
