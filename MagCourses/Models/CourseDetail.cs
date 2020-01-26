using System.ComponentModel;

namespace MagCourses.Models
{
    public class CourseDetail
    {
        [DisplayName("Course")]
        public string CourseName { get; set; }

        [DisplayName("Number Teachers")]
        public int NumberTeachers { get; set; }

        [DisplayName("Number Students")]
        public int NumberStudents { get; set; }

        [DisplayName("Average")]
        public double Average { get; set; }
    }
}