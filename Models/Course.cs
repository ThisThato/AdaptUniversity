using AdaptUniversity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptUniversity.Models
{
   
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public Grade? Grade { get; set; }

        public Course(int CourseID)
        {
            this.CourseID = CourseID;
        }
    }
}
