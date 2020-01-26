using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MagCourses.DAL;
using MagCourses.Models;
using MagCourses.Repository;
using MagCourses.Services;

namespace MagCourses.Controllers
{
    public class StudentsController : Controller
    {

        private StudentsService service = new StudentsService();

        // GET: Students1
        public ActionResult Index()
        {
            return View(service.GetAllStudents());
        }

        // GET: Students1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = service.GetStudentById(id.Value);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Students1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Students1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentID,RegistrationNumber,Name,Birthday")] Student student)
        {
            if (ModelState.IsValid)
            {
                service.CreateStudent(student);
                return RedirectToAction("Index");
            }

            return View(student);
        }

        // GET: Students1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = service.GetStudentById(id.Value);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentID,RegistrationNumber,Name,Birthday")] Student student)
        {
            if (ModelState.IsValid)
            {

                service.UpdateStudent(student);

                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: Students1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = service.GetStudentById(id.Value);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            service.DeleteStudentById(id);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                service.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
