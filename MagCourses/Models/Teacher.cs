using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MagCourses.Models
{
    public class Teacher : Person
    {

        public int TeacherID { get; set; }
        public double Salary { get; set; }
        
    }
}