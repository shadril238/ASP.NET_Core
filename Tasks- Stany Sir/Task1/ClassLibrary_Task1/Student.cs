//Author: shadril238

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Task1
{
    public class Student
    {
        public int sem;
        public string name, id;
        public float cgpa;

        public Student()
        {

        }

        public void setValues(int sem, string id, string name, float cgpa)
        {
            this.sem = sem;
            this.id = id;
            this.name = name;
            this.cgpa = cgpa;
            
        }

        public void displayValues()
        {
            Console.WriteLine("Name : " + name + "\nID : " + id + "\nCGPA : " + cgpa + "\nTotal Semester : " + sem);
        }

    }
}
