using AdaptUniversity.Models;
using System;

namespace AdaptUniversity.Factories
{
    public class CourseFactory
    {
        public static Course Create(string courseTitle, string courseId, int credits)
        {
            try
            {
                return new Course(courseId)
                {
                    Title = courseTitle,
                    Credits = credits
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
           
        }


    }
}
