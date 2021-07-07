using AdaptUniversity.Controllers;
using AdaptUniversity.Models;
using System;
using System.Collections.Generic;

namespace AdaptUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentController studentController = new StudentController();

            studentController.Enroll(new Student("2015072990") { ID = "2015072990", FirstName = "Thato" });


            Student student = studentController.GetStudent("2015072990");

            Console.WriteLine($"{student.StudentNumber} {student.FirstName}");

            Console.WriteLine("Hello World!");
        }
    }
}
