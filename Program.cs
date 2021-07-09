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
            EnrollmentLogic enrollmentLogic = new EnrollmentLogic();


            string id = "20020312345679", studentNumber = "2020123700", firstName = "John", lastName = "Doe", lectureNumber = "123456", type = "Student";
            string courseId = "00215", title = "Data Structures"; int credits = 16;

            IPerson person = null;
            if (type == "Student")
                person = PersonFactory<Student>.Create(id, studentNumber, firstName, lastName);
            if (type == "Lecturer")
                person = PersonFactory<Lecturer>.Create(id, lectureNumber, firstName, lastName);



            Student student = (Student)person;


            Student std = studentLogic.GetStudentByStudentNumber(studentNumber);
            Course course = CourseFactory.Create(courseId, title, credits);
            Enrollment enrollment = EnrollmentFactory.Create(course, std, "Enrollment-021");


            studentLogic.AddStudent(student);
            enrollmentLogic.Enroll(enrollment);


            string variable = enrollmentLogic.GetEnrollmentByID("Enrollment-021").Course.Title;


            Console.WriteLine(variable);
            Console.WriteLine(std.LastName);

            Console.ReadLine();
        }

    }
}
