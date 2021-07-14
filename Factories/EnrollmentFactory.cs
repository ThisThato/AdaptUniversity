using System;
using Domain.Models;

namespace AdaptUniversity.Factories
{
    public class EnrollmentFactory
    {

        public static Enrollment Create(Course course, Student student, string enrollmentID)
        {
            try
            {
                return new Enrollment()
                {
                    Course = course,
                    Student = student,
                    EnrollmentId = enrollmentID
                };
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
           
        }
    }
}
