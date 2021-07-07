using AdaptUniversity.Models;
using AdaptUniversity.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptUniversity.Controllers
{
    public class StudentController
    {
         private StudentRepository repository;

        public StudentController()
        {
            repository = new StudentRepository();
        }

        public void Enroll(Student student)
        {
            repository.AddStudent(student);
        }

        public void UnEnroll(string studentNumber)
        {
            repository.DeleteStudent(studentNumber);
        }

        public void Edit(Student student)
        {
            repository.UpdateStudent(student);
        }

        public Student GetStudent(string studentNumber)
        {
            return repository.GetStudentByStudentNumber(studentNumber);
        }

        private List<Student> GetAllStudents()
        {
            return repository.GetAllStudents();
        }


    }
}
