//Author: Shadril Hassan Shifat [20-42451-1] 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Student
    {
        private string name, id, department;
        private float cgpa;

        public Student()
        {
            Console.WriteLine("Default constructor of Student class is called.");
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
        public float Cgpa
        {
            get
            {
                return cgpa;
            }
            set
            {
                cgpa = value;   
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Student Name : " + this.name + " \nStudent ID : " + this.id + "\nStudent Department : " + this.department + "\nStudent CGPA : " + this.cgpa);
        }

    }
}
