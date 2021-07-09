using AdaptUniversity.Enums;

namespace AdaptUniversity.Models
{
   
    public class Course
    {
        public string CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
       
        public Course(string CourseID)
        {
            this.CourseID = CourseID;
        }
    }
}
