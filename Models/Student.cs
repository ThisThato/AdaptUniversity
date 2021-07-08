using AdaptUniversity.Enums;


namespace AdaptUniversity.Models
{
    public class Student : IPerson
    {
        public string StudentNumber { get; set; }
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Grade? Grade { get; set;  }
        
        public Student(string studentNumber)
        {
            this.StudentNumber = studentNumber;
        }
        public Student()
        {

        }

    }
}
