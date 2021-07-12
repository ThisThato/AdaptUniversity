using AdaptUniversity.Models;
using AdaptUniversity.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptUniversity.Logic
{
    public class LecturerLogic
    {
        public LecturerRepository repository;

        public LecturerLogic()
        {
            repository = new LecturerRepository();
        }

        public  void AddLecturer(Lecturer entity)
        {

            if (repository.Find(entity) == null)
                repository.Add(entity);
            else
                throw new Exception($"Lecturer - {entity.UniqueID} already added.");

           
        }

        public void DeleteLecturer(Lecturer entity)
        {

            if (repository.Find(entity) != null)
                repository.Delete(entity);
            else
                throw new Exception($"Lecturer - {entity.UniqueID} does not exists.");

        }

        public Lecturer GetLecturerById(string lecturerId)
        {
            try
            {
                Lecturer entity = repository.GetByID(lecturerId);
                if (entity != null)
                    return entity;
                else
                    throw new Exception($"Invalid {lecturerId}. Lecturer not found. ");
            }
               catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return default;
            }
        }

        public void UpdateLecturer(Lecturer newLecturer, Lecturer oldLecturer)
        {

            if (repository.Find(oldLecturer) != null)
                repository.Update(oldLecturer, newLecturer);
            else
                throw new Exception($"Error - {oldLecturer.UniqueID} not Found. ");
        }
    }
}
