using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MagCourses.Models
{
    public class StudentDetail
    {
        [DisplayName("Student Name")]
        public string StudentName { get; set; }

        [DisplayName("Grades")]
        public List<StudentSubjectGrade> StudentSubjectGrade { get; set; }
    }
}