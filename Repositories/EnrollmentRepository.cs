using AdaptUniversity.Interfaces;
using AdaptUniversity.Models;
using System.Collections.Generic;
using System.Linq;

namespace AdaptUniversity.Repositories
{
    public class EnrollmentRepository : IRepository<Enrollment>
    {
        private List<Enrollment> enrollments;

        public EnrollmentRepository()
        {
            enrollments = new List<Enrollment>();
        }   

        public void Add(Enrollment enrollment)
        {
            enrollments.Add(enrollment);
        }

        public Enrollment Get(string enrollmentId)
        {
           return  enrollments.Find(e => e.EnrollmentId == enrollmentId);
        }

        public Enrollment Find(Enrollment enrollment)
        {
            return enrollments.FirstOrDefault(e => e == enrollment);
        }

        public void Delete(Enrollment enrollment)
        {
            enrollments.Remove(enrollment);
        }

        public void Update(Enrollment oldEnrollment, Enrollment newEnrollment)
        {
            enrollments[enrollments.IndexOf(oldEnrollment)] = newEnrollment;
        }

        public IEnumerable<Enrollment> GetAll()
        {
            return enrollments;
        }
    }
}
