using MagCourses.Models;
using MagCourses.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagCourses.Services
{
    public class StudentsService : IDisposable
    {
        private IStudentsRepository _repository = new StudentsRepository();

        public StudentsService()
        {
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _repository.GetStudents();
        }

        public Student GetStudentById(int id)
        {
            return _repository.GetStudentByID(id);
        }

        public void CreateStudent(Student student)
        {
            _repository.InsertStudent(student);
            _repository.Save();
        }

        public void UpdateStudent(Student student)
        {
            _repository.UpdateStudent(student);
            _repository.Save();
        }

        public void DeleteStudentById(int id)
        {
            _repository.DeleteStudent(id);
            _repository.Save();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _repository.Dispose();
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