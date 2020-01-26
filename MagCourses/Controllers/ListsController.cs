using MagCourses.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Linq;
using MagCourses.Models;

namespace MagCourses.Controllers
{
    public class ListsController : Controller
    {
        private MagCoursesContext db = new MagCoursesContext();

        public ActionResult Courses()
        {
            List<CourseDetail> courseDetailList = new List<CourseDetail>();

            List<Course> courses = db.Courses.ToList();

            foreach (var course in courses)
            {
                CourseDetail courseDetail = new CourseDetail();

                courseDetail.CourseName = course.Name;

                courseDetail.NumberTeachers = course.Subjects.Select(m => m.Teacher).Count();

                courseDetail.NumberStudents = db.Enrollments.Where(m => m.CourseID == course.CourseID).Count();

                courseDetail.Average = db.Enrollments.Where(m => m.CourseID == course.CourseID).Select(m => m.Grade).ToList().Average();

                courseDetailList.Add(courseDetail);
            }

            return View(courseDetailList);
        }


        public ActionResult Subjects()
        {
            List<SubjectsDetails> subjectsDetailsList = new List<SubjectsDetails>();

            List<Subject> subjects = db.Subjects.ToList();

            foreach (var subject in subjects)
            {
                SubjectsDetails subjectsDetails = new SubjectsDetails();

                subjectsDetails.SubjectName = subject.Name;

                subjectsDetails.Teacher = subject.Teacher.Name;

                subjectsDetails.NumberOfStudents = db.Enrollments.Where(m => m.SubjectID == subject.SubjectID).Count();

                subjectsDetails.StudentsGrades = db.Enrollments.Where(m => m.SubjectID == subject.SubjectID).Select(m => new StudentGrade { StudentName = m.Student.Name, Grade = m.Grade }).ToList();

                subjectsDetailsList.Add(subjectsDetails);
            }

            return View(subjectsDetailsList);
        }

        public ActionResult Students()
        {
            List<StudentDetail> studentDetailList = new List<StudentDetail>();

            List<Student> students = db.Students.ToList();

            foreach (var student in students)
            {
                StudentDetail studentDetail = new StudentDetail();

                studentDetail.StudentName = student.Name;

                studentDetail.StudentSubjectGrade = db.Enrollments.Where(m => m.StudentID == student.StudentID).Select(m => new StudentSubjectGrade { SubjectName = m.Subject.Name, Grade = m.Grade }).ToList();

                studentDetailList.Add(studentDetail);
            }

            return View(studentDetailList);
        }
    }
}