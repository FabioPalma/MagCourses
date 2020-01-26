using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MagCourses.Models
{
    public class Course
    {
        public Course()
        {
            this.Subjects = new HashSet<Subject>();
        }
        public int CourseID { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }

    }
}