using AdaptUniversity.Models;
using AdaptUniversity.Logic;
using AdaptUniversity.Factories;
using System;

namespace AdaptUniversity
{
    class Program
    {
      
        static void Main(string[] args)
        {

            StudentLogic studentLogic = new StudentLogic();
            
            string ID = "20020312345679", StudentNumber = "2020123700",  FirstName = "John", LastName = "Doe", type="Student";
            string courseId = "00215", title = "Data Structures"; int credits = 16;

            IPerson person = PersonFactory<IPerson>.Create(ID, StudentNumber, FirstName, LastName, type);
            Student student = (Student)person;
              
            studentLogic.AddStudent(student);

            Student std = studentLogic.GetStudentByStudentNumber(StudentNumber);
            Course course = new Course(courseId)
            {
                Title = title, 
                Credits = credits
            };

            Enrollment enrollment = EnrollmentFactory.CreateEnrollment(course, std, "Enrollment-021");

            EnrollmentLogic enrollmentLogic = new EnrollmentLogic();
            enrollmentLogic.Enroll(enrollment);

            string variable = enrollmentLogic.GetEnrollmentByID("Enrollment-021").course.Title;

            Console.WriteLine(variable);
            Console.WriteLine(std.LastName);

            Console.ReadLine();
        }

     }
}
