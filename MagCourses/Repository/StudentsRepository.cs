using MagCourses.DAL;
using MagCourses.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MagCourses.Repository
{
    public class StudentsRepository : IStudentsRepository
    {
        private MagCoursesContext _context = new MagCoursesContext();

        public StudentsRepository()
        {
        }

        public void DeleteStudent(int studentID)
        {
            Student student = _context.Students.Find(studentID);
            _context.Students.Remove(student);
        }

        public Student GetStudentByID(int studentId)
        {
            return _context.Students.Find(studentId);
        }

        public IEnumerable<Student> GetStudents()
        {
            return _context.Students.ToList();
        }

        public void InsertStudent(Student student)
        {
            _context.Students.Add(student);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateStudent(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
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