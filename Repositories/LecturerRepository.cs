using AdaptUniversity.Interfaces;
using AdaptUniversity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptUniversity.Repositories
{
    public class LecturerRepository : IRepository<Lecturer>
    {
        private readonly List<Lecturer> lecturers;

        public LecturerRepository()
        {
            lecturers = new List<Lecturer>();
        }

        public void Add(Lecturer entity)
        {
            lecturers.Add(entity);
        }

        public void Delete(Lecturer entity)
        {
            lecturers.Remove(entity);
        }

        public Lecturer Find(Lecturer enitity)
        {
            return lecturers.Find(l => l == enitity);
        }

        public Lecturer Get(string number)
        {
            return lecturers.Find(l => l.UniqueID == number);
        }

        public IEnumerable<Lecturer> GetAll()
        {
            return lecturers;
        }

        public Lecturer GetByID(string idNumber)
        {
            return lecturers.Find(l => l.UniqueID == idNumber);
        }

        public void Update(Lecturer oldEntity, Lecturer newEntity)
        {
            lecturers[lecturers.IndexOf(oldEntity)] = newEntity;
        }
    }
}
