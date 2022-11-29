using Assignment01.DbContexts;
using Assignment01.Entities;
using System;
namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainingContext context = new TrainingContext();

            //Student student = new Student();
            //student.Name = "Abu Toha";
            //student.DateOfBirth = new DateTime(2000, 2, 1);
            //student.Address = "Madina";

            //context.Students.Add(student);
            //context.SaveChanges();

            //Course course = new Course();
            //course.Title = "C# .Net";
            //course.Fees = 30000;
            //course.DurationInHours = 80;
            //context.Courses.Add(course);
            //context.SaveChanges();
            var course = context.Courses.Where(x => x.Id == 2).FirstOrDefault();
            var student = context.Students.FirstOrDefault();

            course.EnrollmentCourses = new List<Enrollments>();
            course.EnrollmentCourses.Add(new Enrollments { Student = student });

            context.SaveChanges();
        }
    }
}