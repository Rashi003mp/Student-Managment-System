using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Managment_System
{
    internal class StudentManager
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student) 
        {
            students.Add(student);
        }

        public void ViewStudents() 
        {
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Course: {student.Course?.CourseName ?? "N/A"}");
            }
        }

        public void UpdateStudent(int id, string newName, int newAge, Course newCourse) 
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null) 
            {
                student.Name = newName;
                student.Age = newAge;
                student.Course = newCourse;
            }
        }
    }
}
