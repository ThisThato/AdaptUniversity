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

            StudentLogic StudentLogic = new StudentLogic();
            EnrollmentLogic EnrollmentLogic = new EnrollmentLogic();


            string id = "20020312345679", studentNumber = "2020123700", firstName = "John", lastName = "Doe", lectureNumber = "123456", type = "Student";
            string courseId = "00215", title = "Data Structures"; int credits = 16;

            IPerson person = null;
            if (type == "Student")
                person = PersonFactory<Student>.Create(id, studentNumber, firstName, lastName);
            if (type == "Lecturer")
                person = PersonFactory<Lecturer>.Create(id, lectureNumber, firstName, lastName);
            Course course = CourseFactory.Create(courseId, title, credits);


            Student Entity = (Student)person;
            Enrollment Enrollment = EnrollmentFactory.Create(course, Entity, "Enrollment-021");
            StudentLogic.AddStudent(Entity);
            EnrollmentLogic.Enroll(Enrollment);

            Student Student = StudentLogic.GetStudentByStudentNumber(studentNumber);
            string variable = EnrollmentLogic.GetEnrollmentByID("Enrollment-021").Course.Title;
         

            Console.WriteLine(variable);
            Console.WriteLine(Student.LastName);

            Console.ReadLine();
        }

    }
}
