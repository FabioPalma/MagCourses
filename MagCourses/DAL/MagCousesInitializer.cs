using MagCourses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagCourses.DAL
{
    public class MagCousesInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MagCoursesContext>
    {

        protected override void Seed(MagCoursesContext context)
        {
            //********* Students *********
            var students = new List<Student>
            {
            new Student{Name="Ovídio Siqueira",Birthday=DateTime.Parse("1989-01-01"), RegistrationNumber=1},
            new Student{Name="Nico Roque",Birthday=DateTime.Parse("1990-02-01"), RegistrationNumber=2},
            new Student{Name="Anacleto Vaz",Birthday=DateTime.Parse("1991-03-01"), RegistrationNumber=3},
            new Student{Name="Leandra Guerra",Birthday=DateTime.Parse("1992-04-01"), RegistrationNumber=4},
            new Student{Name="Rosália Mendez",Birthday=DateTime.Parse("1993-05-01"), RegistrationNumber=5},
            new Student{Name="Frederica Garcia",Birthday=DateTime.Parse("1994-06-01"), RegistrationNumber=6},

            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();


            //********* Teachers *********

            var teachers = new List<Teacher>
            {
            new Teacher{Name="Alfredo Caetano",Birthday=DateTime.Parse("1970-01-01"), Salary=1000.50},
            new Teacher{Name="Vinícius Gomes",Birthday=DateTime.Parse("1970-02-01"), Salary=1030.30},
            new Teacher{Name="Brígida Machado",Birthday=DateTime.Parse("1970-02-01"), Salary=1500.00},
            };

            teachers.ForEach(s => context.Teachers.Add(s));
            context.SaveChanges();

            //********* Subjects *********

            var subjects = new List<Subject>
            {
            new Subject{Name="Matematica Aplicada", TeacherID=1},
            new Subject{Name="Psicologia Das Coisas", TeacherID=2},
            new Subject{Name="Historia", TeacherID=3}
            };

            subjects.ForEach(s => context.Subjects.Add(s));
            context.SaveChanges();

            Student student1 = context.Students.Find(1);
            Student student2 = context.Students.Find(2);
            Student student3 = context.Students.Find(3);
            Student student4 = context.Students.Find(4);

            Subject subject1 = context.Subjects.Find(1);
            subject1.Students = new List<Student>();
            subject1.Students.Add(student1);
            subject1.Students.Add(student2);

            Subject subject2 = context.Subjects.Find(2);
            subject2.Students = new List<Student>();
            subject2.Students.Add(student1);
            subject2.Students.Add(student3);

            Subject subject3 = context.Subjects.Find(3);
            subject3.Students = new List<Student>();
            subject3.Students.Add(student3);
            subject3.Students.Add(student4);

            context.SaveChanges(); 

            //********* Courses *********

            var courses = new List<Course>
            {
            new Course{Name="Arquitetura", Subjects = { subject1, subject2 } },
            new Course{Name="Finanças e Contabilidade", Subjects = { subject2, subject3 }},
            new Course{Name="Psicologia", Subjects = { subject1, subject3 } }
            };

            

            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();


            //********* Enrollments *********

            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1,SubjectID= 3,Grade=12},
            new Enrollment{StudentID=1,CourseID=2,SubjectID= 1,Grade=14},
            new Enrollment{StudentID=1,CourseID=3,SubjectID= 2,Grade=14},
            new Enrollment{StudentID=2,CourseID=2,SubjectID= 2,Grade=18},
            new Enrollment{StudentID=2,CourseID=3,SubjectID= 1,Grade=14},
            new Enrollment{StudentID=3,CourseID=1,SubjectID= 2,Grade=14},
            new Enrollment{StudentID=4,CourseID=2,SubjectID= 3,Grade=14},
            new Enrollment{StudentID=4,CourseID=3,SubjectID= 1,Grade=12},
            new Enrollment{StudentID=5,CourseID=2,SubjectID= 3,Grade=15},
            new Enrollment{StudentID=6,CourseID=3,SubjectID= 2,Grade=14}
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }

    }
}