using AdaptUniversity.Models;
using AdaptUniversity.Repositories;
using System;


namespace AdaptUniversity.Controllers
{
    public class EnrollmentController
    {
        private StudentRepository repository;
        private EnrollmentRepository enrollmentRepo;

        public EnrollmentController()
        {
            enrollmentRepo = new EnrollmentRepository();
            repository = new StudentRepository();
        }

        public void Enroll(Course course, string studentnumber)
        {
            Student student = repository.GetByStudentNumber(studentnumber);
            if (student != null)
                enrollmentRepo.Create(course, student);
            else
                throw new Exception("Unable to Enroll student. Student not Found");
        }

        public void UnEnroll(string courseTitle, string studentnumber)
        {
            Student student = repository.GetByStudentNumber(studentnumber);
            if (student != null)
                if( !enrollmentRepo.Remove(courseTitle, student))
                    throw new Exception("Unable to Unenroll student.");
                else
                throw new Exception("Unable to Unenroll student. Student not Found.");
        }

       
    }
}
