using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagCourses.Models
{
    public class Student : Person
    {
        public int StudentID { get; set; }
        
        public int RegistrationNumber { get; set; }
    }
}