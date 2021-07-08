using AdaptUniversity.Models;

namespace AdaptUniversity.Factories
{
    public static class PersonFactory<T> where T : IPerson  
    {
        public static IPerson Create(string iD, string number, string firstName, string lastName, string type)
        {
            if (type == "Student")
            {
                return new Student(number)
                {
                    ID = iD,
                    FirstName = firstName,
                    LastName = lastName
                };
            }
            else
            {
                return new Lecturer()
                {
                    ID = iD,
                    FirstName = firstName, 
                    LastName = lastName, 
                    LectureID = number
                };
            }
           
        }
    }
}
