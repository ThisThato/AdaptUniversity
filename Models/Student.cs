using AdaptUniversity.Enums;


namespace AdaptUniversity.Models
{
    public class Student : IPerson
    {

        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Grade? Grade { get; set;  }
        public string UniqueID { get; set; }


    }
}
