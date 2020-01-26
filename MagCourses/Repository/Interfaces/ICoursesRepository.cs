using MagCourses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagCourses.Repository.Interfaces
{
    public interface ICoursesRepository : IDisposable
    {
        IEnumerable<Course> GetCourses();
        Course GetCourseByID(int courseId);
        void InsertCourse(Course course);
        void DeleteCourse(int courseID);
        void UpdateCourse(Course course);
        void Save();
    }
}