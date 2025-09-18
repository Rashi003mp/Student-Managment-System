using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Managment_System
{
    public class Course
    {
        public int CourseId;
        public string CourseName;
    }
    public class Student
    {
        public int Id;
        public string Name;
        public int Age;
        public Course Course;
    }
    public class Mark
    {
        public int MarkId;
        public int Marks;
    } 
}
