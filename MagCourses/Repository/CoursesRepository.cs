using MagCourses.DAL;
using MagCourses.Models;
using MagCourses.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MagCourses.Repository
{
    public class CoursesRepository : ICoursesRepository
    {
        private MagCoursesContext _context = new MagCoursesContext();

        public CoursesRepository()
        {
        }

        public void DeleteCourse(int courseID)
        {
            Course course = _context.Courses.Find(courseID);
            _context.Courses.Remove(course);
        }

        public Course GetCourseByID(int courseID)
        {
            return _context.Courses.Find(courseID);
        }

        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses.ToList();
        }

        public void InsertCourse(Course course)
        {
            _context.Courses.Add(course);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateCourse(Course course)
        {
            _context.Entry(course).State = EntityState.Modified;
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}