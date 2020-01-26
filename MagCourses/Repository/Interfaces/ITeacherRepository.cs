using MagCourses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagCourses.Repository
{
    public interface ITeacherRepository : IDisposable
    {
        IEnumerable<Teacher> GetTeachers();
        Teacher GetTeacherByID(int teacherId);
        void InsertTeacher(Teacher teacher);
        void DeleteTeacher(int teacherID);
        void UpdateTeacher(Teacher teacher);
        void Save();
    }
}