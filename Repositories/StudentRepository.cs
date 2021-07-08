using AdaptUniversity.Interfaces;
using AdaptUniversity.Models;
using System.Collections.Generic;


namespace AdaptUniversity.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
    
        private List<Student> students;

        public StudentRepository()
        {
            students = new List<Student>();
        }

        public void Add(Student student)
        { 
            students.Add(student);
        }  

        public Student Get(string number)
        {
            return students.Find(s => s.StudentNumber == number);
        }

        public Student GetByID(string ID)
        {
            return students.Find(s => s.ID == ID);
        }

        public Student Find(Student student)
        {
           return students.Find(s => s == student);
        }

        public void Delete(Student student)
        {
            students.Remove(student);
        }

        public void Update(Student newStudent, Student oldStudent)
        {
           students[students.IndexOf(oldStudent)] = newStudent;
        }

        public IEnumerable<Student> GetAll()
        {
            return students;
        }

    }     
}

