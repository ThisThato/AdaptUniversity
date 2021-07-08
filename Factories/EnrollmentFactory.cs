using AdaptUniversity.Models;


namespace AdaptUniversity.Factories
{
    public static  class EnrollmentFactory
    {
        public static Enrollment CreateEnrollment(Course course, Student student, string EnrollmentID)
        {
            return new Enrollment()
            {
                course = course, 
                student = student, 
                enrollmentId = EnrollmentID
            };
        }
    }
}
