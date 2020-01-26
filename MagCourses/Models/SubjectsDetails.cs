using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MagCourses.Models
{
    public class SubjectsDetails
    {
        [DisplayName("Subject")]
        public string SubjectName { get; set; }

        [DisplayName("Teacher")]
        public string Teacher { get; set; }

        [DisplayName("Number Of Students")]
        public int NumberOfStudents { get; set; }

        [DisplayName("Grades")]
        public List<StudentGrade> StudentsGrades { get; set; }
    }
}