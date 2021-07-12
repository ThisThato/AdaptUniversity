using AdaptUniversity.Models;
using AdaptUniversity.Repositories;
using System.Collections.Generic;
using System;


namespace AdaptUniversity.Logic
{
    public class EnrollmentLogic
    {
        private EnrollmentRepository repository;

        public EnrollmentLogic()
        {
            repository = new EnrollmentRepository();
        }

        public void Enroll(Enrollment enrollment)
        {
            if (repository.Find(enrollment) == null)
                repository.Add(enrollment);
            else
               throw new Exception("Unable to Enroll. Enrollment already exists");

        }

        public void UnEnroll(Enrollment enrollment)
        {
            if (repository.Find(enrollment) != null)
                repository.Delete(enrollment);
            else
                throw new Exception("Unable to UnEnroll. Enrollment not Found.");

        }

        public void UpdateEnrollment(Enrollment oldEnrollment, Enrollment newEnrollment)
        {
            if (repository.Find(oldEnrollment) != null)
                repository.Update(oldEnrollment, newEnrollment);
            else
                throw new Exception("Unable to Update Enrollment. Enrollment does not exist.");
        }

        public Enrollment GetEnrollmentByID(string enrollmentID)
        {

            Enrollment Enrollment = repository.Get(enrollmentID);
            if (Enrollment != null)
                return Enrollment;
            else
                throw new Exception($"Enrollment - {enrollmentID} not found.");
        }
           

        public Enrollment GetEnrollment(Enrollment entity)
        {

            Enrollment Enrollment = repository.Find(entity);
            if (Enrollment != null)
                return Enrollment;
            else
            {
                Console.WriteLine($"Invalid Enrollment - {entity}. Enrollment not found. ");
                return null;
            }

        }

       public IEnumerable<Enrollment> GetAllEnrollments()
        {
            try
            {
                return repository.GetAll();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }      
    }
}
