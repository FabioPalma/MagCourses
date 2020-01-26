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

        [DisplayFormat(DataFormatString = "{0:C2}")]
        public double Salary { get; set; }
        
    }
}