using AdaptUniversity.Models;
using System;

namespace AdaptUniversity.Factories
{
    public static class PersonFactory<T> where T : class,  IPerson, new()
    {


        public static IPerson Create(string id, string number, string firstName, string lastName)
        {

            try
            {
                T item = new T()
                {
                    ID = id,
                    FirstName = firstName,
                    LastName = lastName,
                    UniqueID = number
                };
                return item;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
           
        }
    }
}
