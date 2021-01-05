using Microsoft.AspNetCore.Mvc;
using UniversityTracker.Models;
using System.Collections.Generic;
using System.Linq; // LINQ is short for Language-Integrated Query
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering; // gives access to SelectList

namespace UniversityTracker.Controllers
{
  public class CoursesController : Controller
  {
    private readonly UniversityTrackerContext _db;
    public CoursesController(UniversityTrackerContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Courses.ToList());
    }

    public ActionResult Create()
    {
      ViewBag.StudentId = new SelectList(_db.Students, "StudentId", "Name"); // Course can belong to Student that already exists
      return View();
    }

    [HttpPost]
    public ActionResult Create(Course course, int StudentId)
    {
      _db.Courses.Add(course);
      if (StudentId != 0)
      {
        _db.Enrollment.Add(new Enrollment() { StudentId = StudentId, CourseId = course.CourseId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
        var thisCourse = _db.Courses
          .Include(course => course.Students)
          .ThenInclude(join => join.Student)
          .FirstOrDefault(course => course.CourseId == id);
        return View(thisCourse);
    }

    public ActionResult Edit(int id)
    {
      var thisCourse = _db.Courses.FirstOrDefault(course => course.CourseId == id);
      ViewBag.StudentId = new SelectList(_db.Students, "StudentId", "Name");
      return View(thisCourse);
    }

    [HttpPost]
    public ActionResult Edit(Course course, int StudentId)
    {
      if (StudentId != 0)
      {
        _db.Enrollment.Add(new Enrollment() { StudentId = StudentId, CourseId = course.CourseId });
      }
      _db.Entry(course).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddStudent(int id)
    {
      var thisCourse = _db.Courses.FirstOrDefault(courses => courses.CourseId == id);
      ViewBag.StudentId = new SelectList(_db.Students, "StudentId", "Name");
      return View(thisCourse);
    }

    [HttpPost]
    public ActionResult AddStudent(Course course, int StudentId)
    {
      if (StudentId != 0)
      {
        _db.Enrollment.Add(new Enrollment() { StudentId = StudentId, CourseId = course.CourseId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}