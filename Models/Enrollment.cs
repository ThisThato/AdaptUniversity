using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptUniversity.Models
{
    public class Enrollment
    {
        public string EnrollmentId { get; set; }
        public Student Student{get; set; }
        public Course Course { get; set;  }

       
    }
}
