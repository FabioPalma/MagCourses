using MagCourses.DAL;
using MagCourses.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MagCourses.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        private MagCoursesContext _context = new MagCoursesContext();

        public TeacherRepository()
        {
        }

        public void DeleteTeacher(int teacherID)
        {
            Teacher teacher = _context.Teachers.Find(teacherID);
            _context.Teachers.Remove(teacher);
        }

        public Teacher GetTeacherByID(int teacherId)
        {
            return _context.Teachers.Find(teacherId);
        }

        public IEnumerable<Teacher> GetTeachers()
        {
            return _context.Teachers.ToList();
        }

        public void InsertTeacher(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateTeacher(Teacher teacher)
        {
            _context.Entry(teacher).State = EntityState.Modified;
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