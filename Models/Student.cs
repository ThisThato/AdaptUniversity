using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptUniversity.Models
{
    public class Student : IPerson
    {
        public string StudentNumber { get; set; }
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Course> Courses { get; set; }
        
        public Student(string studentNumber)
        {
            this.StudentNumber = studentNumber;
        }

    }
}
