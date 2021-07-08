using System;
using System.Collections.Generic;

namespace AdaptUniversity.Interfaces
{
    interface IRepository<T> where T : class, new()
    {
        void Add(T entity);

        T Get(string number);
        
        T GetByID(string idNumber);
        
        T Find(T enitity);

        void Delete(T entity);

        void Update(T oldEntity, T newEntity);

        IEnumerable<T> GetAll();
    }
}
