using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MagCourses.Models
{
    public abstract class Person
    {
        [Required]
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }
}