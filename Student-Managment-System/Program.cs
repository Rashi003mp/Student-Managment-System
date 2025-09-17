using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Managment_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CourseManager courseManager = new CourseManager();
            courseManager.AddCourse(new Course { CourseId = 1, CourseName = "Maths" });
            courseManager.AddCourse(new Course { CourseId = 1, CourseName = "Science" });
            courseManager.ViewCourse();

            StudentManager studentManager = new StudentManager();
            studentManager.AddStudent(new Student { Id = 1, Name = "Alice", Age = 20, Course = courseManager.GetCourseById(1) });
            studentManager.AddStudent(new Student { Id = 2, Name = "Bob", Age = 22, Course = courseManager.GetCourseById(2) });

            studentManager.ViewStudents();


        }
    }
}
