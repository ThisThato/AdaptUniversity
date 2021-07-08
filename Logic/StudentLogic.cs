﻿using System;
using System.Collections.Generic;
using AdaptUniversity.Models;
using System.Linq;
using AdaptUniversity.Repositories;

namespace AdaptUniversity.Logic
{
    public class StudentLogic
    {
        private StudentRepository repository;

        public StudentLogic()
        {
            repository = new StudentRepository();
        }

        public void AddStudent(Student student)
        {
            if (repository.Find(student) != null)
                repository.Add(student);
            else
                throw new Exception($"Student - {student.StudentNumber} already Exixts");
        }

        public Student GetStudentByStudentNumber(string studentNumber)
        {
            Student student = repository.Get(studentNumber);
            if (student != null)
                return student;
            else
                throw new Exception($"Student - {studentNumber} not found.");
        }

        public IEnumerable<Student> GetStudents()
        {
            return repository.GetAll() != null ? repository.GetAll() : throw new Exception("No students found");
        }

        public void UpdateStudent(Student newStudent)
        {
            Student oldStudent = repository.Find(newStudent);
            if (oldStudent != null)
                repository.Update(newStudent, oldStudent);
            else
                throw new Exception($"Student - {oldStudent.StudentNumber} not found");
        }

        public void RemoveStudent(Student _student)
        {
            Student student = repository.Find(_student);
            if (student != null)
                repository.Delete(student);
            else
                throw new Exception($"Unable to delete. /n Student - {student.StudentNumber} not found.");
        }
    }
}
