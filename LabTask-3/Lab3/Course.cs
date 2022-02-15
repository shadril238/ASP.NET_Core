//Author: Shadril Hassan Shifat [20-42451-1] 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Course
    {
        private string courseName, courseCode;
        public int courseCredit;

        public Course()
        {
            Console.WriteLine("Default constructor of Course class is called.");
        }
        public string CourseName
        {
            get 
            { 
                return courseName; 
            }
            set 
            { 
                courseName = value; 
            }
        }
        public string CourseCode
        {
            get 
            { 
                return courseCode; 
            }
            set 
            { 
                courseCode = value; 
            }
        }
        public int CourseCredit
        {
            get 
            { 
                return courseCredit; 
            }
            set 
            { 
                courseCredit = value; 
            }
        }

        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name : " + this.courseName);
            Console.WriteLine("Course Code : " + this.courseCode);
            Console.WriteLine("Course Credit : " + this.courseCredit);
        }
    }
}
