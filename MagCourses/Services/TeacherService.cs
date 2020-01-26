using MagCourses.Models;
using MagCourses.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagCourses.Services
{
    public class TeacherService : IDisposable
    {
        private ITeacherRepository _repository = new TeacherRepository();

        public TeacherService()
        {

        }

        public IEnumerable<Teacher> GetAllTeachers()
        {
            return _repository.GetTeachers();
        }

        public Teacher GetTeacherById(int id)
        {
            return _repository.GetTeacherByID(id);
        }

        public void CreateTeacher(Teacher teacher)
        {
            _repository.InsertTeacher(teacher);
            _repository.Save();
        }

        public void UpdateTeacher(Teacher teacher)
        {
            _repository.UpdateTeacher(teacher);
            _repository.Save();
        }

        public void DeleteTeacherById(int id)
        {
            _repository.DeleteTeacher(id);
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