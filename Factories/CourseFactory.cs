using AdaptUniversity.Models;

namespace AdaptUniversity.Factories
{
    public class CourseFactory
    {
        public static Course Create(string courseTitle, string courseId, int credits)
        {
            return new Course(courseId)
            {
                Title = courseTitle,
                Credits = credits
            };
        }


    }
}
