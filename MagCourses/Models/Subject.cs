using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MagCourses.Models
{
    public class Subject
    {
        public Subject()
        {
            this.Courses = new HashSet<Course>();
        }

        public int SubjectID { get; set; }

        [Required]
        public string Name { get; set; }

        public int TeacherID { get; set; }

        public virtual Teacher Teacher { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}