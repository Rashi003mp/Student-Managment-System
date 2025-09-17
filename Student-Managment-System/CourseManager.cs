using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Managment_System
{
    internal class CourseManager
    {
        private List<Course> courses = new List<Course>();

        public void AddCourse(Course course) 
        {
            courses.Add(course);
        }

        public void ViewCourse() 
        {
            foreach (var course in courses)
            {
                Console.WriteLine($"Course ID: {course.CourseId}, Course Name: {course.CourseName}");
            }
        }

        public Course GetCourseById(int courseId) 
        {
            return courses.FirstOrDefault(c => c.CourseId == courseId);
        }

    }
}
