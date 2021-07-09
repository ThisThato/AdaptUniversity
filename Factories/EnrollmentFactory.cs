using AdaptUniversity.Models;


namespace AdaptUniversity.Factories
{
    public class EnrollmentFactory
    {

        public static Enrollment Create(Course course, Student student, string EnrollmentID)
        {
            return new Enrollment()
            {
                Course = course, 
                Student = student, 
                EnrollmentId = EnrollmentID
            };
        }
    }
}
