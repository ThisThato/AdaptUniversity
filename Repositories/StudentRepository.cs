using System;
using System.Collections.Generic;
using System.Text;
using AdaptUniversity.Models;
using System.Linq;

namespace AdaptUniversity.Repositories
{
    public class StudentRepository
    {
        private List<Student> students;

        public StudentRepository()
        {
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            if(!students.Exists(s => s.StudentNumber == student.StudentNumber))
                students.Add(student);
            else
                throw new Exception("Student already added");
        }

        public Student GetStudentByStudentNumber(string studentNumber)
        {
            Student student = students.Find(s => s.StudentNumber == studentNumber);
            if (student != null)
            {
                return student;
            }
            else
                throw new Exception("Student not found. Invalid student ID.");
        }

        public List<Student> GetAllStudents()
        {
           return students != null ? students : throw new Exception("No students found");
        }

        public void UpdateStudent(Student student)
        {

            Student item = students.FirstOrDefault(s => s.StudentNumber == student.StudentNumber);

            if (item != null)
                students[students.IndexOf(item)] = student;
            else
                throw new Exception("Student not found");
        }

        public void DeleteStudent(string studentNumber)
        {
          Student student = students.FirstOrDefault(s => s.StudentNumber == studentNumber);
            if (student != null)
                students.Remove(student);
            else
                throw new Exception("Student not found. Invalid student ID.");
        }
    }
}
