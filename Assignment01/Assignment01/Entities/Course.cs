using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Fees { get; set; }
        public int DurationInHours { get; set; }
        public List<Enrollments> EnrollmentCourses { get; set; }
    }
}
