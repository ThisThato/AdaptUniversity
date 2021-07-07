using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptUniversity.Models
{
    public class Lecture : IPerson
     {
        public string ID { get; set; }
        public string LectureID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Course> Courses { get; set; }

        public Lecture(string lectureID)
        {
            this.LectureID = lectureID;
        }
    }
}
