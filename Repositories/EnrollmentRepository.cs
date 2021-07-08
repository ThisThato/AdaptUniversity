using AdaptUniversity.Models;
using System.Collections.Generic;

namespace AdaptUniversity.Repositories
{
    public class EnrollmentRepository
    {
        private List<Enrollment> enrollments;

        public EnrollmentRepository()
        {
            enrollments = new List<Enrollment>();
        }   

        public void Create(Course course, Student student)
        {
            enrollments.Add(new Enrollment
            {
                course = course,
                student = student
            });
        }

        public void Update(Enrollment newEnrollment, Enrollment oldEnrollment)
        {
            enrollments[enrollments.IndexOf(oldEnrollment)] = newEnrollment;
        }

        public bool Remove(string courseTitle, Student student)
        {
            Enrollment enrollment = Find(courseTitle, student);
            if (enrollment != null)
            {
                enrollments.Remove(enrollment);
                return true;
            }
            else
                return false;

        }

        public Enrollment Find(string courseTitle, Student student)
        {
            Enrollment enrollment = enrollments.Find(e => e.course.Title == courseTitle);
            if (enrollment.student == student)
                return enrollment;
            else
               return null;
        }

    }
}
