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
           
        }

        public void UpdateEnrollment(Enrollment oldEnrollment, Enrollment newEnrollment)
        {
            if (repository.Find(oldEnrollment) != null)
                repository.Update(oldEnrollment, newEnrollment);
            else
                throw new Exception("Unable to Update Enrollment. Enrollment does not exist.");
        }

        public Enrollment GetEnrollmentByID(string EnrollmentID)
        {
            Enrollment enrollment = repository.Get(EnrollmentID);
            if (enrollment != null)
                return enrollment;
            else
                throw new Exception($"Invalid Enrollment ID {EnrollmentID}. Unable to Get Enrollment. ");
        }

        public Enrollment GetEnrollment(Enrollment entity)
        {
            Enrollment enrollment = repository.Find(entity);
            if (enrollment != null)
                return enrollment;
            else
                throw new Exception($"Invalid Enrollment - {entity}. Enrollment not found. ");
        }

       public IEnumerable<Enrollment> GetAllEnrollments()
        {
            return repository.GetAll();
        }

      
    }
}
